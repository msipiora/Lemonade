using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade
{
    class Store
    {
        
        public double PurchasedLemons;
        public double PurchasedIce;
        public double PurchasedCups;
        public double PurchasedSugar;
        public double LemonSale;
        public double IceSale;
        public double CupSale;
        public double SugarSale;
        public double LemonPrice = .10;
        public double IcePrice = .05;
        public double CupsPrice = .10;
        public double SugarPrice = .10;
        public string IngredientSelection;


        public Store()
        {

        }

        public void PurchaseIngredients(Player player)
        {
            Console.WriteLine("\nType the ingredient you would like to purchase. 'lemon' 'ice' 'cup' 'sugar' or type 'return' to access the main menu\n");
            IngredientSelection = Console.ReadLine();
            switch (IngredientSelection)
            {
                case "lemon":
                    {
                        Console.WriteLine($"\nLemons cost {LemonPrice} each, how many would you like? You currently have {player.Inventory.LemonList.Count} lemons and your wallet currently has ${player.Wallet}\n");
                        PurchasedLemons = double.Parse(Console.ReadLine());
                        LemonSale = (PurchasedLemons * LemonPrice);
                        if (player.Wallet < LemonSale)
                        {
                            Console.WriteLine("Not enough cash bozo\n");
                            PurchaseIngredients(player);
                        }
                        else
                        {
                            player.Wallet = player.Wallet - LemonSale;
                            AddLemonInventory(player);
                            Console.WriteLine($"{PurchasedLemons} lemons have been added to your inventory\n");
                            PurchaseIngredients(player);
                        }
                        
                        break;
                    }
                case "ice":
                    {
                        Console.WriteLine($"\nIce costs {IcePrice} per ice cube, how much would you like? You currently have {player.Inventory.IceList.Count} ice and your wallet currently has ${player.Wallet}\n");
                        PurchasedIce = double.Parse(Console.ReadLine());
                        IceSale = (PurchasedIce * IcePrice);
                        if (player.Wallet < IceSale)
                        {
                            Console.WriteLine("Not enough cash bozo\n");
                            PurchaseIngredients(player);
                        }
                        else
                        {
                            player.Wallet = player.Wallet - IceSale;
                            AddIceInventory(player);
                            Console.WriteLine($"{PurchasedIce} ice cubes have been added to your inventory\n");
                            PurchaseIngredients(player);

                        }

                        break;
                    }
                case "cup":
                    {
                        Console.WriteLine($"\nCups cost {CupsPrice}, how many would you like? You currently have {player.Inventory.CupList.Count} cups and your wallet currently has ${player.Wallet}\n");
                        PurchasedCups = double.Parse(Console.ReadLine());
                        CupSale = (PurchasedCups * CupsPrice);
                        if (player.Wallet < CupSale)
                        {
                            Console.WriteLine("Not enough cash bozo\n");
                            PurchaseIngredients(player);
                        }
                        else
                        {
                            player.Wallet = player.Wallet - CupSale;
                            AddCupInventory(player);
                            Console.WriteLine($"{PurchasedCups} cups have been added to your inventory\n");
                            PurchaseIngredients(player);


                        }
                        break;
                    }
                case "sugar":
                    {
                        Console.WriteLine($"\nSugar costs {SugarPrice} per sugar packet, how many would you like? You currently have {player.Inventory.SugarList.Count} sugar packets and your wallet currently has ${player.Wallet}\n");
                        PurchasedSugar = double.Parse(Console.ReadLine());
                        SugarSale = (PurchasedSugar * SugarPrice);
                        if (player.Wallet < SugarSale)
                        {
                            Console.WriteLine("Not enough cash bozo\n");
                            PurchaseIngredients(player);
                        }
                        else
                        {
                            player.Wallet = player.Wallet - SugarSale;
                            AddSugarInventory(player);
                            Console.WriteLine($"{PurchasedSugar} sugar packets have been added to your inventory\n");
                            PurchaseIngredients(player);


                        }
                        break;
                    }
                case "return":
                    {
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Invalid selection\n");
                        PurchaseIngredients(player);
                        break;
                    }

            }
        }

        public void AddLemonInventory(Player player)
        {
            for (int i = 0; i < PurchasedLemons; i++)
            {
                player.Inventory.LemonList.Add(new Lemon());
               
            }

        }
        public void AddIceInventory(Player player)
        {
            for (int i = 0; i < PurchasedIce; i++)
            {
                player.Inventory.IceList.Add(new Ice());

            }

        }
        public void AddSugarInventory(Player player)
        {
            for (int i = 0; i < PurchasedSugar; i++)
            {
                player.Inventory.SugarList.Add(new Sugar());

            }

        }
        public void AddCupInventory(Player player)
        {
            for (int i = 0; i < PurchasedCups; i++)
            {
                player.Inventory.CupList.Add(new Cup());

            }

        }
    }
}
