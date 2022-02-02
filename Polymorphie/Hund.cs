using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphie
{
    public class Hund : Tier
    {
        public override void Bewegen()
        {
            Console.WriteLine("Der Hund läuft polymorph davon.");
        }

        public new void Stoppen()
        {
            Console.WriteLine("Der Hund wurde polymorph gestoppt!");
        }
    }
}
