using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphie
{
    public class Wombat : Tier
    {
        public override void Bewegen()
        {
            Console.WriteLine("Das Wombat humpelt polymorph davon.");
        }
        public new void Stoppen()
        {
            Console.WriteLine("Das Wombat wurde polymorph gestoppt!");
        }
    }
}
