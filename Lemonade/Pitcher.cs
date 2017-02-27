using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade
{
    class Pitcher
    {
        public int GlassCounter;
        public Pitcher()
        {

        }


        public bool CheckIngredients(Player player)
        {            
            {
                if (player.Inventory.LemonList.Count > player.Inventory.LemonsUsed && player.Inventory.SugarList.Count > player.Inventory.SugarUsed)
                {
                    return true;
                }

                else
                {
                    Console.WriteLine("You ran out of ingredients and have to close down for the day.");
                    return false;
                }
            }
         
        }

        public void FillPitcher(Player player)
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

        public void PourGlass(Player player)
        {            
            {
                player.Inventory.CupList.RemoveAt(0);
                GlassCounter = GlassCounter + 1;
                if (GlassCounter% 5 == 0)
                {
                    FillPitcher(player);
                }
            }

        }
    }
}
