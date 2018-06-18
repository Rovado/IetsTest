using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {

            //Int's zijn types. In dit geval een integer die een getal als waarde krijgt.
            int a = 5;
            int b = 2;
            int c = 10;

            b = a;
            a = -3;
            
            
            //$" Doet inline placeholders. Wel de values in parenthesis'!
            Console.WriteLine($"{a}  {b}");

            //{0} en {1} zijn placeholders. Index gebaseerd, begint bij 0, 1, etc.
            Console.WriteLine("{0} {1}", a, b);

            //Bewijs dat 0 en 1 placeholders zijn en gerecycled kunnen worden.
            //De waarden hangen vast aan de gedefineerde integers.
            Console.WriteLine("{0} {1}", c, b);

            //Er is een limiet aan 32 bit en de int type is 32 bit.
            //Als het goed is is het limiet ongeveer 2 miljard.
            //  int OverHetLimietHeen = 4000000000;
            //  Console.WriteLine(OverHetLimietHeen);

            // MaxInt++ geeft de grooste variabele mogelijk. 
            //In dit geval -2147483648

            int maxInt = Int32.MaxValue;
            maxInt++;
            Console.WriteLine(maxInt);

            //Er zijn 4 types 
            {
                long aVeryBigNumber = 395904282569;
                aVeryBigNumber = 13;
                Console.WriteLine(aVeryBigNumber);
            }
            //Hier staat een vraag voor de gebruiker; "Wat is jouw naam?"
            Console.WriteLine("Wat is jouw naam?");

            //Hier wordt ingegeven wat het antwoord is van de gebruiker.
            string IngaveNaam = Console.ReadLine();
            Console.WriteLine($"Okee, hallo {IngaveNaam}");

            //Hier wordt een willekeurig getal aangemaakt.
            int WillekeurigGetal = new Random().Next(100);

            Console.WriteLine(WillekeurigGetal);


        }
    }
}
