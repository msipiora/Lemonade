using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade
{
    class Inventory
    {
        public Pitcher Pitcher;
        public List<Sugar> SugarList;
        public List<Cup> CupList;
        public List<Lemon> LemonList;
        public List<Ice> IceList;
        public int LemonsUsed;
        public int SugarUsed;
        public int IceUsed;


        public Inventory()
        {
            SugarList = new List<Sugar>();
            CupList = new List<Cup>();
            LemonList = new List<Lemon>();
            IceList = new List<Ice>();
            Pitcher = new Pitcher();
        }
        public void DisplayInventory()
        {
            Console.WriteLine($"Your Inventory consists of the following \n Lemons: {LemonList.Count}\n Sugar: {SugarList.Count}\n Ice: {IceList.Count}\n Cups: {CupList.Count}");
        }

        public void LemonRecipe()
        {
            Console.WriteLine("\n Prepare a lemonade mix for tomorrow's customers. You must use at least 1 lemon and 1 sugar packet in each pitcher, ice cubes are optional.\n One pitcher's worth of ingredients serves five customers.\n");
            Console.WriteLine("How many lemons in one pitcher?\n");
            LemonsUsed = int.Parse(Console.ReadLine());
            if (LemonsUsed==0)
            {
                Console.WriteLine("You need at least 1 lemon in your recipe");
                LemonRecipe();
                    
            }
            else if (LemonsUsed > LemonList.Count)
            {
                Console.WriteLine("You don't have enough lemons in your inventory. Go to the store and buy more. \n");
            }

            else if (LemonsUsed <= LemonList.Count)
            {
                Console.WriteLine($"{LemonsUsed} lemons per pitcher selected.");
                SugarRecipe();
            }

            else
            {
                Console.WriteLine("Invalid selection");
                LemonRecipe();
            }

        }

        public void SugarRecipe()
        {
            Console.WriteLine("How many sugar packets in one pitcher?\n");
            SugarUsed = int.Parse(Console.ReadLine());
            if (SugarUsed == 0)
            {
                Console.WriteLine("You need at least 1 sugar packet in your recipe");

            }
            else if (SugarUsed > SugarList.Count)
            {
                Console.WriteLine("You don't have enough sugar packets in your inventory. Go to the store and buy more. \n");
                SugarRecipe();
            }

            else if (SugarUsed <= SugarList.Count)
            {
                Console.WriteLine($"{SugarUsed} sugar packets per pitcher selected.");
                IceRecipe();
            }

            else
            {
                Console.WriteLine("Invalid selection");
                SugarRecipe();
            }
        }

        public void IceRecipe()
        {
            Console.WriteLine("How much ice in one pitcher?\n");
            IceUsed = int.Parse(Console.ReadLine());
            if (IceUsed > IceList.Count)
            {
                Console.WriteLine("You don't have enough ice in your inventory. Go to the store and buy more. \n");
            }

            else if (IceUsed <= IceList.Count)
            {
                Console.WriteLine($"{IceUsed} ice cubes per pitcher selected.\n");
                Console.WriteLine($"Tomorrow's recipe set: \nLemons per pitcher: {LemonsUsed} \nSugar packets per pitcher: {SugarUsed} \nIce cubes per pitcher: {IceUsed}");
            }

            else
            {
                Console.WriteLine("Invalid selection");
                IceRecipe();
            }
        }

    }
}
