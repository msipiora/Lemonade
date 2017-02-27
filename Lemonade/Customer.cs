using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade
{
    class Customer
    {

        //member variables
        public int MinimumTemperature;
        public string PreferredCondition;
        public int PreferredIce;
        public int PreferredLemons;
        public int PreferredSugar;
        public double MaxPrice;
        public int CupsSold = 0;
        Random random = new Random();
        List<string> Conditions = new List<string>() { "Sunny", "Sunny", "Sunny", "Cloudy", "Rainy", "Windy" };

        //constructor initialize the class, pass in attributes
        public Customer(int MinimumTemperature, int PreferredCondition, int PreferredIce, int PreferredLemons, int PreferredSugar, double MaxPrice)
        {
            this.MinimumTemperature = MinimumTemperature;
            this.PreferredCondition = Conditions[PreferredCondition];
            this.PreferredIce = PreferredIce;
            this.PreferredLemons = PreferredLemons;
            this.PreferredSugar = PreferredSugar;
            this.MaxPrice = MaxPrice;
            
        }

        public void BuyLemonade(Player player)
        {
        }
    }
}

        //methods
