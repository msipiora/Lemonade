using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade
{
    class Weather
    {
        public string Condition;
        public int Temperature;
        public int DetermineWeather;
        public int Sunny;
        public int Rainy;
        public int Windy;
        public int Cloudy;
        Random random = new Random();
        List<string> conditions;
        //member variables



        //constructor
    public Weather ()
        {
            conditions = new List<string>() { "Sunny", "Sunny", "Sunny", "Cloudy", "Rainy", "Windy" };
            this.Condition = conditions[random.Next(0, 5)];
            this.Temperature = random.Next(50,100);
    //        GenerateWeather();
        }

        //public void GenerateWeather()
        //{
        //    DetermineWeather = random.Next(0, 100);
        //    if (DetermineWeather < 51)
        //    {
        //        this.Condition = 1; //Sunny
        //    }

        //    else if (DetermineWeather < 71 && DetermineWeather > 51)
        //    {
        //        this.Condition = 2; //Cloudy
        //    }

        //    else if (DetermineWeather < 86 && DetermineWeather > 71)
        //    {
        //        this.Condition = 3; //Windy
        //    }

        //    else
        //    {
        //        this.Condition = 4; //Rainy
        //    }

        //}
        
        //methods


    }
}
