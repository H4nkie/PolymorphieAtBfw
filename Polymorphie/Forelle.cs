using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphie
{
    public class Forelle : Tier
    {
        public override void Bewegen()
        {
            Console.WriteLine("Die Forelle schwimmt polymorph davon.");
        }
        public new void Stoppen()
        {
            Console.WriteLine("Die Forelle wurde polymorph gestoppt!");
        }
    }
}
