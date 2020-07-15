using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Irobotvsdinosaur
{
    class Robots
    {
        public string robotName;
        public int robotHealth;
        public int robotPower;
        public Weapon weapon;
        public int robotAttackPower;



        public Robots(string robotName)
        {
            this.robotName = robotName;
            robotHealth = 100;
            robotPower = 100;
            weapon = new Weapon("ball");
            robotAttackPower = 50;

        }

        public void Attack(Dinosaur DinoToAttack)
        {
            DinoToAttack.dinoHealth -= robotAttackPower;
            if (DinoToAttack.dinoHealth == 0)
            {
                Console.WriteLine(" Dead");
            }
            else
            {
                DinoToAttack.dinoHealth -= robotAttackPower;
            }

            if (robotPower == 0)
            {
                Console.WriteLine(" Needs Power");
            }
            else robotPower -= robotAttackPower;






        }

    }
}
