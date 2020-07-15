using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Irobotvsdinosaur
{
    class Herd
    {
        public List<Dinosaur> TheDinosaurs;

        public Herd()
        {
            TheDinosaurs = new List<Dinosaur>();
            
            Dinosaur someDType = new Dinosaur ("Tyran");
            Dinosaur someDType1 = new Dinosaur("Micro");
            Dinosaur someDType2 = new Dinosaur("Triceratop");
            TheDinosaurs.Add(someDType);
            TheDinosaurs.Add(someDType1);
            TheDinosaurs.Add(someDType2);
            //TheDinosaurs.RemoveAt(0);
        }
            

    }
}
