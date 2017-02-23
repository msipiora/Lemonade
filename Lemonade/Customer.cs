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
        
        public int PreferredTemperature;
        public string PreferredCondition;
        public int PreferredIce;
        public int PreferredLemons;
        public int PreferredSugar;
        public double MaxPrice;

        //constructor initialize the class, pass in attributes
        public Customer(int PreferredTemperature, string PreferredCondition, int PreferredIce, int PreferredLemons, int PreferredSugar, double MaxPrice)
        {
            this.PreferredTemperature = PreferredTemperature;
            this.PreferredCondition = PreferredCondition;
            this.PreferredIce = PreferredIce;
            this.PreferredLemons = PreferredLemons;
            this.PreferredSugar = PreferredSugar;
            this.MaxPrice = MaxPrice;
            
        }
    }
}

        //methods
