using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Irobotvsdinosaur
{
    class Battlefield
    {
        public Fleet fleet;
        public Herd herd;


        public Battlefield ()
        {
            fleet = new Fleet();
            herd = new Herd();
        }
        public void RunGame()
        {


            //Remove a robo/dino from the list when it dies?
            //
            while (fleet.TheRobots.Count > 0 && herd.TheDinosaurs.Count > 0)
            {
                   fleet.TheRobots[0].Attack(herd.TheDinosaurs[0]);
                
                if (herd.TheDinosaurs[0].dinoHealth <= 0)
                {
                    herd.TheDinosaurs.RemoveAt(0);
                    if(herd.TheDinosaurs.Count==0)
                    {
                        break;
                    }

                }

                herd.TheDinosaurs[0].Attack(fleet.TheRobots[0]);
                
                if(fleet.TheRobots[0].robotHealth <= 0)
                {
                    fleet.TheRobots.RemoveAt(0);
                } 
                
            }
            if(fleet.TheRobots.Count >=0)
            {
                Console.WriteLine(" Robots Win");
            }
            else
            {
                Console.WriteLine(" Dino win");
            }








        }
    }
}

        

    


          
         






