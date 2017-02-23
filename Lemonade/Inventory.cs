using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade
{
    class Inventory
    {

        public List<Sugar> SugarList;
        public List<Cup> CupList;
        public List<Lemon> LemonList;
        public List<Ice> IceList;


        public Inventory()
        {
            SugarList = new List<Sugar>();
            CupList = new List<Cup>();
            LemonList = new List<Lemon>();
            IceList = new List<Ice>();
        }
        public void DisplayInventory()
        {
            Console.WriteLine($"Your Inventory consists of the following shit:\n Lemons: {LemonList.Count}\n Sugar: {SugarList.Count}\n Ice: {IceList.Count}\n Cups: {CupList.Count}");
        }
    }
}
