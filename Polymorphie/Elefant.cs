using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphie
{
    public class Elefant : Tier
    {   
        public override void Bewegen()
        {
            
            Console.WriteLine("Der Elefant trampelt polymorph herum.");
        }
        public new void Stoppen()
        {
            Console.WriteLine("Der Elefant wurde polymorph gestoppt!");
        }
    }
}
