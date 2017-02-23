using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade
{
    class Day
    {
        Weather weather;
        public List<Customer> Customer1;
        Customer customer1;
        Customer customer2;
        Customer customer3;
        Customer customer4;
        Customer customer5;
        Customer customer6;
        Customer customer7;
        Customer customer8;
        List<Customer> customers;
        int maxNumberOfCustomers = 50;
        Random rnd = new Random();
        //member variables

        public Day()
        {
            customers = new List<Customer>();
        }

        public void GenerateCustomers()
        {
            for(int i = 0; i < maxNumberOfCustomers; i++)
            {
                customers.Add(new Customer(rnd.Next(50, 100), weather.Condition, rnd.Next(0, 3), rnd.Next(1, 6), rnd.Next(1, 6), rnd.Next(1, 5)));
            }
            // Customer(int PreferredTemperature, int PreferredCondition, double PreferredIce, double PreferredLemons, double PreferredSugar, double MaxPrice)
            customer1 = new Customer(60-100, "Sunny", 0-2, 1, 1, 1.50);
            customer2 = new Customer(50-70, "Sunny", 3, 3, 2, 1.00);
            customer3 = new Customer(50-100, "Windy", 1, 1, 1, 1.25);
            customer4 = new Customer(80-100, "Windy", 2, 2, 2, 0.50);
            customer5 = new Customer(50-80, "Rainy", 0, 3, 4, 0.75);
            customer6 = new Customer(70 - 100, "Sunny", 3, 2, 3, 2.00);
            customer7 = new Customer(65 - 100, "Cloudy", 3, 2, 3, 1.75);
            customer8 = new Customer(60 - 100, "Cloudy", 2, 1, 1, 1.25);
        }

        //public void DailyWeather()
        //{
        //    SunnyWeather = new Weather(1);
        //    SunnyWeather.Temperature
        //}
        //public void WillingnessToBuy(Customer)

        //If customer is at the store, their likelihood to buy increases if lemonade contains the amount of ingredients they want
        //25%+ if one match, +40% if two, +60% if three, +20% if temp 85+
        //Sunny = 1
        //Cloudy = 2
        //Windy = 3
        //Rainy = 4
    }

}
