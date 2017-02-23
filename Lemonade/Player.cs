using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade
{
    class Player
    {
        Inventory Inventory;
        public double Wallet = 20.00;
        public string PlayerName;

        public Player()
        {

        }

        public string GetName()
        {
            Console.WriteLine("Enter your name:");
            PlayerName = Console.ReadLine();
            return PlayerName;
        }
    }
}
