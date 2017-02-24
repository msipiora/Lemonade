using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade
{
    class Player
    {
        public Inventory Inventory;
        public Pitcher Pitcher;
        public double Wallet = 50.00;
        public string PlayerName;

        public Player()
        {
            Inventory = new Inventory();
        }

        public string GetName()
        {
            Console.WriteLine("Enter your name:");
            PlayerName = Console.ReadLine();
            return PlayerName;
        }
    }
}
