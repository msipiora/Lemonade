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
        Day NewDay;
        public Money Wallet = new Money();
        public string MenuOptions;
        public int DayCounter = 1;


        public Game()
        {
            player = new Player();
            store = new Store();
            weather = new Weather();
            NewDay = new Day(weather);
        }
        
      

        public void Intro()
        {
            Console.WriteLine("Welcome to Lemonade Stand. In this game you will have 7 days to make that money, as much as you possibly can.\n Success requires smart pricing, supply and demand, and some good luck on the weather forecast. \n");
            player.GetName();

            MainMenu();

        }

        public void MainMenu()
        {
            Console.WriteLine($"Welcome to Day {DayCounter}. Main Menu: \nType 'inventory' to check your supplies. \nType 'store' to purchase supplies. \nType Once you have your supplies, type 'start' to prepare a lemonade mix and start selling. \nTomorrow's forecast is: {weather.Condition} {weather.Temperature} degrees Fahrenheit. \nYour wallet contains ${player.Wallet}");
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
                case "start":
                    player.Inventory.LemonRecipe();
                    NewDay.SelectPrice();
                    NewDay.ForecastAccuracy();
                    NewDay.LoopCustomers(player);
                    NewDay.DayResults(player);
                    DayCounter = DayCounter + 1;
                    if (DayCounter == 8)
                    {
                        Console.WriteLine($"\nGame over {player.PlayerName}. Your wallet started at $50 and ended at  ${player.Wallet}.\n");
                        Console.ReadLine();
                    }
                    NewDay = new Day(weather);
                    weather = new Weather();
                    MainMenu();
                    break;
                default:
                    Console.WriteLine("Invalid selection\n");
                    MainMenu();
                    break;
            }

        }
    }
}
