using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade
{

    class Day
    {
        public int SetPrice;
        Weather weather;
        List<Customer> customers;
        int maxNumberOfCustomers = 50;
        Random rnd = new Random();
        //member variables

        public Day()
        {
            customers = new List<Customer>();
            weather = new Weather();
        }

        public void GenerateCustomers()
        {
            for(int i = 0; i < maxNumberOfCustomers; i++)
            {
                customers.Add(new Customer(rnd.Next(50, 100), weather.Condition, rnd.Next(0, 3), rnd.Next(1, 6), rnd.Next(1, 6), rnd.Next(1, 5)));
            }

        }


        public bool WeatherAvailability(Customer customers)
        {
            if (customers.PreferredCondition != weather.Condition  && customers.MinimumTemperature > weather.Temperature && customers.MaxPrice > SetPrice)
            {
                return false;
            }
            else
            {
                return true;
            }
            }

        public void SelectPrice()
        {
            Console.WriteLine("Set the price for one cup of lemonade. Customers tend to pay between $1 and $5 for a cup of lemonade");
            SetPrice = int.Parse(Console.ReadLine());

        }

        public void EagernessToBuy(Customer customers, Player player)
        {
            Random rand = new Random();
            int chance = rand.Next(1, 101);

            if (customers.PreferredLemons == player.Inventory.LemonsUsed && customers.PreferredSugar == player.Inventory.SugarUsed && customers.PreferredIce == player.Inventory.IceUsed)
            {               
                    customers.BuyLemonade(player);
            }
            else if (customers.PreferredLemons == player.Inventory.LemonsUsed || customers.PreferredSugar == player.Inventory.SugarUsed && customers.PreferredIce == player.Inventory.IceUsed)
            {
                if (chance > 33)
                {
                    customers.BuyLemonade(player);
                }
            }
            else if (customers.PreferredLemons == player.Inventory.LemonsUsed && customers.PreferredSugar == player.Inventory.SugarUsed || customers.PreferredIce == player.Inventory.IceUsed)
            {
                if (chance > 33)
                {
                    customers.BuyLemonade(player);
                }
            }
            else if (customers.PreferredLemons == player.Inventory.LemonsUsed && customers.PreferredIce == player.Inventory.IceUsed || customers.PreferredSugar == player.Inventory.SugarUsed)
            {
                if (chance > 33)
                {
                    customers.BuyLemonade(player);
                }
            }
            else
            {
                if (chance > 66)
                {
                    customers.BuyLemonade(player);
                }
            }
        }


    }

        //If customer is at the store, their likelihood to buy increases if lemonade contains the amount of ingredients they want
        //25%+ if one match, +40% if two, +60% if three, +20% if temp 85+
        //Sunny = 1
        //Cloudy = 2
        //Windy = 3
        //Rainy = 4
    }


