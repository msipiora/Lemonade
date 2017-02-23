using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade
{
    class Store
    {
        Game menu;
        Inventory Inventory;
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
        public double SugarPrice = .25;
        public string IngredientSelection;


        public Store()
        {

        }

        public void PurchaseIngredients(Player player)
        {
            Console.WriteLine("Type the ingredient you would like to purchase. 'lemon' 'ice' 'cup' 'sugar' or type 'return' to access the main menu");
            IngredientSelection = Console.ReadLine();
            switch (IngredientSelection)
            {
                case "lemon":
                    {
                        Console.WriteLine($"Lemons cost {LemonPrice} each, how many would you like? You currently have {Inventory.LemonList.Count} lemons and your wallet currently has {player.Wallet}");
                        PurchasedLemons = double.Parse(Console.ReadLine());
                        LemonSale = (PurchasedLemons * LemonPrice);
                        if (player.Wallet < LemonSale)
                        {
                            Console.WriteLine("Not enough cash bozo");
                            PurchaseIngredients(player);
                        }
                        else
                        {
                            player.Wallet = player.Wallet - LemonSale;
                            AddLemonInventory();
                            PurchaseIngredients(player);
                        }
                        
                        break;
                    }
                case "ice":
                    {
                        Console.WriteLine($"Ice costs {IcePrice} for 10 cups worth of ice, how much would you like? You currently have {Inventory.IceList.Count} ice and your wallet currently has {player.Wallet}");
                        PurchasedIce = double.Parse(Console.ReadLine());
                        IceSale = (PurchasedIce * IcePrice);
                        if (player.Wallet < IceSale)
                        {
                            Console.WriteLine("Not enough cash bozo");
                            PurchaseIngredients(player);
                        }
                        else
                        {
                            player.Wallet = player.Wallet - IceSale;
                            AddIceInventory();
                            PurchaseIngredients(player);
                        }

                        break;
                    }
                case "cup":
                    {
                        Console.WriteLine($"Cups cost {CupsPrice}, how many would you like? You currently have {Inventory.CupList.Count} cups and your wallet currently has {player.Wallet}");
                        PurchasedCups = double.Parse(Console.ReadLine());
                        CupSale = (PurchasedCups * CupsPrice);
                        if (player.Wallet < SugarSale)
                        {
                            Console.WriteLine("Not enough cash bozo");
                            PurchaseIngredients(player);
                        }
                        else
                        {
                            player.Wallet = player.Wallet - CupSale;
                            AddCupInventory();
                            PurchaseIngredients(player);

                        }
                        break;
                    }
                case "sugar":
                    {
                        Console.WriteLine($"Sugar costs {SugarPrice} for 10 sugar packets, how much would you like? You currently have {Inventory.SugarList.Count} sugar packets and your wallet currently has {player.Wallet}");
                        PurchasedSugar = double.Parse(Console.ReadLine());
                        SugarSale = (PurchasedSugar * SugarPrice);
                        if (player.Wallet < SugarSale)
                        {
                            Console.WriteLine("Not enough cash bozo");
                            PurchaseIngredients(player);
                        }
                        else
                        {
                            player.Wallet = player.Wallet - SugarSale;
                            AddSugarInventory();
                            PurchaseIngredients(player);

                        }
                        break;
                    }
                case "return":
                    {
                        //menu.MainMenu(Wallet);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Invalid selection");
                        PurchaseIngredients(player);
                        break;
                    }

            }
        }

        public void AddLemonInventory()
        {
            for (int i = 0; i < PurchasedLemons; i++)
            {
                Inventory.LemonList.Add(new Lemon());
               
            }

        }
        public void AddIceInventory()
        {
            for (int i = 0; i < PurchasedIce; i++)
            {
                Inventory.IceList.Add(new Ice());

            }

        }
        public void AddSugarInventory()
        {
            for (int i = 0; i < PurchasedSugar; i++)
            {
                Inventory.SugarList.Add(new Sugar());

            }

        }
        public void AddCupInventory()
        {
            for (int i = 0; i < PurchasedCups; i++)
            {
                Inventory.CupList.Add(new Cup());

            }

        }
    }
}
