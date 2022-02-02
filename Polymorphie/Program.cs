using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tier[] tiere = new Tier[10];
            tiere[0] = new Hund() { Alter=2, Name="Bello" };
            tiere[1] = new Katze() { Alter = 15, Name = "Muschi" };
            tiere[2] = new Elefant() { Alter = 21, Name = "Dumbo" };
            tiere[3] = new Moewe() { Alter = 1, Name = "Trude" };
            tiere[4] = new Igel() { Alter = 4, Name = "Evil" };
            tiere[5] = new Elster() { Alter = 2, Name = "Frau Elster" };
            tiere[6] = new Goldfisch() { Alter = 30, Name = "Sam" };
            tiere[7] = new Forelle() { Alter = 25, Name = "Ella" };
            tiere[8] = new Wombat() { Alter = 7, Name = "Flixxi" };
            tiere[9] = new Schlange() { Alter = 77, Name = "Khan" };

            LassDieTiereLos(tiere);
        }

        static void LassDieTiereLos(Tier[] tiere)
        {
            foreach(Tier tier in tiere)
            {
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("Ein Object der Klasse: " + tier.GetType());
                Console.WriteLine("Name: " + tier.Name );
                Console.WriteLine("Alter: " + tier.Alter );
                Console.WriteLine("Nach einem kleinen Schubser:");
                tier.Bewegen();
                tier.Stoppen();
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
