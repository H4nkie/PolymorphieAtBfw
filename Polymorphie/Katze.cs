using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphie
{
    public class Katze : Tier
    {
        public override void Bewegen()
        {
            Console.WriteLine("Die Katze stolziert polymorph herum.");
        }
        public new void Stoppen()
        {
            Console.WriteLine("Die Katze wurde polymorph gestoppt!");
        }
    }
}
