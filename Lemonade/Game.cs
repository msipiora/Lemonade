using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade
{
    class Game
    {
        Store store;
        Player player;
        Weather weather;
        public Money Wallet = new Money();
        public string MenuOptions;

        //member variables


        //constructor

        public Game()
        {
            player = new Player();
            store = new Store();
            weather = new Weather();
        }




        //methods

        public void Intro()
        {
            Console.WriteLine("Welcome to Lemonade Stand. In this game you will have 7 days to make that money, as much as you possibly can.\n Success requires smart pricing, supply and demand, and some good luck on the weather forecast. \n");
            player.GetName();

            MainMenu();

        }

        public void MainMenu()
        {
            Console.WriteLine($"Main Menu: \nType 'inventory' to check your supplies. \nType 'store' to purchase supplies. \nType 'recipe' to prepare a lemonade mix for tomorrow's customers. \nTomorrow's forecast is: {weather.Condition} {weather.Temperature} degrees Fahrenheit. \nYour wallet contains ${player.Wallet}");
            MenuOptions = Console.ReadLine().ToLower();
            switch (MenuOptions)
            {

                case "store":
                    store.PurchaseIngredients(player);
                    MainMenu();
                    break;
                case "inventory":
                    player.Inventory.DisplayInventory();
                    MainMenu();
                    break;
                case "recipe":
                    player.Inventory.LemonRecipe();
                    MainMenu();
                    break;

                default:
                    Console.WriteLine("Invalid selection\n");
                    MainMenu();
                    break;
            }
            //Build out functionality to check inventory, go to the store, check weather, display the day. The whole game is accessible from here.
            //Console clear to 
        }
    }
}
