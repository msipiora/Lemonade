using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade
{
    class Pitcher
    {
        Player player;
        
        public Pitcher()
        {

        }


        public bool CheckIngredients()
        {            
            {
                if (player.Inventory.LemonList.Count > player.Inventory.LemonsUsed && player.Inventory.SugarList.Count > player.Inventory.SugarUsed)
                {
                    return true;
                }

                else
                {
                    return false;
                }
            }
         
        }

        public void FillPitcher()
        {
            for (int i = 0; i < player.Inventory.LemonsUsed; i++)
            {
                player.Inventory.LemonList.RemoveAt(0);
            }
            for (int i=0; i < player.Inventory.SugarUsed; i++)
            {
                player.Inventory.SugarList.RemoveAt(0);
            }
            for (int i = 0; i < player.Inventory.IceUsed; i++)
            {
                player.Inventory.IceList.RemoveAt(0);
            }
        }

        public void PourGlass()
        {
            if (player.Inventory.CupList.Count == 0)
            {
                Console.WriteLine("You ran out of cups. You will have to close down your lemonade stand for the rest of the day");
            }
            for(int i = 0; i < 5; i++)
            {
                player.Inventory.CupList.RemoveAt(0);
            }
        }
    }
}
