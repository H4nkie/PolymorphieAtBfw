using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphie
{
    public class Schlange : Tier
    {
        public override void Bewegen()
        {
            Console.WriteLine("Die Schlange lauert polymorph und wartet auf die Maus.");
        }
        public new void Stoppen()
        {
            Console.WriteLine("Die Schlange wurde polymorph gestoppt!");
        }
    }
}
