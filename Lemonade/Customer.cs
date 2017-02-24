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
        Day day;
        public int MinimumTemperature;
        public string PreferredCondition;
        public int PreferredIce;
        public int PreferredLemons;
        public int PreferredSugar;
        public double MaxPrice;

        //constructor initialize the class, pass in attributes
        public Customer(int MinimumTemperature, string PreferredCondition, int PreferredIce, int PreferredLemons, int PreferredSugar, double MaxPrice)
        {
            this.MinimumTemperature = MinimumTemperature;
            this.PreferredCondition = PreferredCondition;
            this.PreferredIce = PreferredIce;
            this.PreferredLemons = PreferredLemons;
            this.PreferredSugar = PreferredSugar;
            this.MaxPrice = MaxPrice;
            
        }

        public void BuyLemonade(Player player)
        {
            player.Wallet = player.Wallet + day.SetPrice;
        }
    }
}

        //methods
