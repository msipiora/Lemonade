﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade
{

    public class Day
    {
        public int SetPrice;
        Weather weather;
        List<Customer> customers;
        int maxNumberOfCustomers = 50;
        Random rnd = new Random();
        public int CupsSold;
        public Money money;


        public Day(Weather forecast)
        {
            customers = new List<Customer>();
            weather = forecast;
            money = new Money();
        }

        public void ForecastAccuracy()
        {
            Random rnd = new Random();
            int chance = rnd.Next(0, 100);
            if (chance > 85)
            {
                weather = new Weather();
                Console.WriteLine($"\nThe weather channel's forecast was inaccurate. The weather is actually {weather.Condition} {weather.Temperature} degrees Fahrenheit today.\n");
            }
            

        }

        public void SelectPrice()
        {
            try
            {
                Console.WriteLine("Set the price for one cup of lemonade. Customers tend to pay between $1 and $5 for a cup of lemonade, or potentially more if the temperature is hot enough.");
                SetPrice = int.Parse(Console.ReadLine());
            }
            catch(Exception)
            {
                Console.WriteLine("Invalid input");
                SelectPrice();
            }
        }

        public void GenerateCustomers()
        {
            for(int i = 0; i < maxNumberOfCustomers; i++)
            {
                customers.Add(new Customer(rnd.Next(50, 100), rnd.Next(0,5), rnd.Next(0, 3), rnd.Next(1, 6), rnd.Next(1, 6), rnd.Next(1, 5)));
            }

        }



        public void LoopCustomers(Player player)
        {
            GenerateCustomers();
            for (int i = 0; i < customers.Count; i++)
            {
           if(CustomerAvailability(customers[i]))
                {
                    bool result = player.Inventory.Pitcher.CheckIngredients(player);
                    if  (result == false)
                        {
                        break;
                        }
                    EagernessToBuy(customers[i], player);
                    bool result2 = player.Inventory.Pitcher.CheckCups(player);
                    if (result2 == false)
                    {
                        break;
                    }
                }
          }
            player.Wallet = player.Wallet + (CupsSold * SetPrice);
        }

        public bool CustomerAvailability(Customer customer)
        {

            if (customer.PreferredCondition != weather.Condition && customer.MinimumTemperature > weather.Temperature && customer.MaxPrice > SetPrice)
                {
                return false;
                }
                else
                {
                return true;
                }
            }
            


        public void EagernessToBuy(Customer customer, Player player)
        {
            Random rand = new Random();
            int chance = rand.Next(1, 101);
            if (weather.Temperature > 85)
            {
                customer.MaxPrice = customer.MaxPrice * 2;
            }
            if (customer.PreferredLemons == player.Inventory.LemonsUsed && customer.PreferredSugar == player.Inventory.SugarUsed && customer.PreferredIce == player.Inventory.IceUsed)
            {
                bool result2 = player.Inventory.Pitcher.CheckCups(player);
                if (result2 == false)
                {
                    return;
                }
                player.Inventory.Pitcher.PourGlass(player);
                CupsSold = CupsSold + 1;

            }
            if(customer.PreferredLemons == player.Inventory.LemonsUsed || customer.PreferredSugar == player.Inventory.SugarUsed && customer.PreferredIce == player.Inventory.IceUsed)
            {
                if (chance > 33)
                {
                    bool result2 = player.Inventory.Pitcher.CheckCups(player);
                    if (result2 == false)
                    {
                        return;
                    }
                    player.Inventory.Pitcher.PourGlass(player);
                    CupsSold = CupsSold + 1;
                }
            }
            if (customer.PreferredLemons == player.Inventory.LemonsUsed && customer.PreferredSugar == player.Inventory.SugarUsed || customer.PreferredIce == player.Inventory.IceUsed)
            {
                if (chance > 33)
                {
                    bool result2 = player.Inventory.Pitcher.CheckCups(player);
                    if (result2 == false)
                    {
                        return;
                    }
                    player.Inventory.Pitcher.PourGlass(player);
                    CupsSold = CupsSold + 1;
                }
            }
            if (customer.PreferredLemons == player.Inventory.LemonsUsed && customer.PreferredIce == player.Inventory.IceUsed || customer.PreferredSugar == player.Inventory.SugarUsed)
            {
                if (chance > 33)
                {
                    bool result2 = player.Inventory.Pitcher.CheckCups(player);
                    if (result2 == false)
                    {
                        return;
                    }
                    player.Inventory.Pitcher.PourGlass(player);
                    CupsSold = CupsSold + 1;
                }
            }
            if (customer.PreferredLemons == player.Inventory.LemonsUsed || customer.PreferredIce == player.Inventory.IceUsed || customer.PreferredSugar == player.Inventory.SugarUsed)
            {
                if (chance > 66)
                {
                    bool result2 = player.Inventory.Pitcher.CheckCups(player);
                    if (result2 == false)
                    {
                        return;
                    }
                    player.Inventory.Pitcher.PourGlass(player);
                    CupsSold = CupsSold + 1;
                }
            }
        }
        public void DayResults(Player player)
        {
            if (player.Inventory.CupList.Count == 0)
            {
                Console.WriteLine("\nYou ran out of cups and had to close down for the day\n");
            }
            money.DayEndSales = (CupsSold * SetPrice);
            player.WeekEarnings = player.WeekEarnings + (CupsSold * SetPrice);

            Console.WriteLine($"\nDay finished. You sold {CupsSold} cups of lemonade. \n You made ${money.DayEndSales} today. Your wallet now stands at ${player.Wallet}\n");
            
        }


    }


    }


