using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphie
{
    public class Elster : Tier
    {
        public override void Bewegen()
        {
            Console.WriteLine("Die Elster fliegt polymorph davon.");
        }
        public new void Stoppen()
        {
            Console.WriteLine("Die Elster wurde polymorph gestoppt!");
        }
    }
}
