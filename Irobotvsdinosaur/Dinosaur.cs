using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Irobotvsdinosaur
{
    class Dinosaur
    {
        public string dinoType;
        public int dinoHealth;
        public int dinoEnergy;
        public int dinoAttackPower;



        public Dinosaur(string dinoType)
        {
            this.dinoType = dinoType;
            dinoHealth = 100;
            dinoEnergy = 100;
            dinoAttackPower = 50;

        }
        public void Attack( Robots RobotToAttack)
        {
            RobotToAttack.robotHealth -= dinoAttackPower;
            if (RobotToAttack.robotHealth == 0)
            {
                Console.WriteLine(" Death");
            }
            else RobotToAttack.robotHealth -= dinoAttackPower;
            if (dinoEnergy == 0)
            {
                Console.WriteLine(" Needs Power");
            }
            else dinoEnergy -= dinoAttackPower;
        }
    }
}
