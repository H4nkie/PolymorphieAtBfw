using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphie
{
    public class Tier
    {   
        public string Name { get; set; }
        public int Alter { get; set; }
        public virtual void Bewegen()
        {
            Console.WriteLine("Das Tier bewegt sich ohne Polymorphie!");
        }
        public void Stoppen()
        {
            Console.WriteLine("Das Tier wurde ohne Polymorhpie gestoppt!");
        }
    }
}
