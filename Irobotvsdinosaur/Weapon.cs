using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Irobotvsdinosaur
{
    class Weapon
    {
        public string type;
        public int attackPower;


        public Weapon(string type)
        {
            this.type = type;
            attackPower = 10;
        }
        
        
    }
}
