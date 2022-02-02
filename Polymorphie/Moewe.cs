using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphie
{
    public class Moewe : Tier
    {
        public override void Bewegen()
        {
            Console.WriteLine("Die Möwe fliegt polymorph davon.");
        }
        public new void Stoppen()
        {
            Console.WriteLine("Die Möwe wurde polymorph gestoppt!");
        }
    }
}
