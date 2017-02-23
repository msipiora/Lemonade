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
        Inventory inventory;
        public Money Wallet = new Money();
        public string MenuOptions;

        //member variables


        //constructor

        public Game()
        {
            player = new Player();
            store = new Store();
            weather = new Weather();
            inventory = new Inventory();
        }




        //methods

        public void Intro()
        {
            Console.WriteLine("Welcome to Lemonade Stand. In this game you will have 7 days to make that money, as much as you possibly can.\n Success requires smart pricing, supply and demand, and some good luck on the weather forecast. Watch out for the occasional asshole customer \n");
            player.GetName();
            MainMenu();
        }

        public void MainMenu()
        {
            Console.WriteLine($"{player.PlayerName}, this is the main menu.\n  Type 'inventory' to check your supplies.\n Type 'store' to purchase supplies.\n Tomorrow's forecast is: {weather.Condition} {weather.Temperature} degrees Fahrenheit");
            MenuOptions = Console.ReadLine().ToLower();
            switch (MenuOptions)
            {

                case "store":
                    store.PurchaseIngredients(player);
                    break;
                case "inventory":
                    inventory.DisplayInventory();
                    MainMenu();
                    break;
                default:
                    Console.WriteLine("Invalid selection");
                    MainMenu();
                    break;
            }
            //Build out functionality to check inventory, go to the store, check weather, display the day. The whole game is accessible from here.
        }
    }
}
