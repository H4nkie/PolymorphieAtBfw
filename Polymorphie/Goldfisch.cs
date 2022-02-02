using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphie
{
    public class Goldfisch : Tier
    {
        public override void Bewegen()
        {
            Console.WriteLine("Der Goldfisch dreht polymorph ein paar extrarunden in seinem Glas.");
        }
        public new void Stoppen()
        {
            Console.WriteLine("Der Goldfisch wurde polymorph gestoppt!");
        }
    }
}
