using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphie
{
    public class Igel : Tier
    {
        public override void Bewegen()
        {
            Console.WriteLine("Der Igel schleicht polymorph davon.");
        }
        public new void Stoppen()
        {
            Console.WriteLine("Der Igel wurde polymorph gestoppt!");
        }
    }
}
