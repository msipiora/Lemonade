using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade
{
    public class Weather
    {
        public string Condition;
        public int Temperature;
        Random random = new Random();
        List<string> conditions;

        

        
    public Weather ()
        {
            conditions = new List<string>() { "Sunny", "Sunny", "Sunny", "Cloudy", "Rainy", "Windy" };
            this.Condition = conditions[random.Next(0, 5)];
            this.Temperature = random.Next(50,100);

        }

    }
}
