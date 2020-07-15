using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Irobotvsdinosaur
{
    class Fleet
    {
        public List<Robots> TheRobots;
      

        public Fleet()
        {
            TheRobots = new List<Robots>();
            Robots somerobots = new Robots(" Alpha ");
            Robots somerobots1 = new Robots(" Bravo");
            Robots somerobots2 = new Robots("Charlie");
            TheRobots.Add(somerobots);
            TheRobots.Add(somerobots1);
            TheRobots.Add(somerobots2);
          
        }  
    }
}
