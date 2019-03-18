using System;   // A System névtér használata

namespace Masterin24Hrs
{
    /* Area
    class Area  // Osztálydeklaráció. Bevezetjük az Area osztályt
    {
        static void Main()  // Ez a program kiindulópontja
        {
            // Deklarációk | változók bevezetése
            int radius = 4;     // sugár, r
            const double pi = 3.14159;      // pí
            double area;    // terület

            // Értékadó utasítás | számítás (kör területe = r négyzet * pí)
            area = (radius * radius) * pi;

            // Függvényhívás | eredmény kiírása
            Console.WriteLine("Sugár: {0}, Pí: {1}", radius, pi);
            Console.WriteLine("A köre területe: {0}", area);
            Console.ReadKey();
        }
    }
    */

    /* varValues
    class varValues  // Osztálydeklaráció. Bevezetjük az Area osztályt
    {
        static void Main()  // Ez a program kiindulópontja
        {
            // firstVar bevezetése
            int firstVar;

            // secondVar bevezetése
            int secondVar = 200;

            // Értékadás
            firstVar = 5;

            // Érték kiírása
            Console.WriteLine("\nfirstVar értéke: {0}", firstVar);
            Console.WriteLine("secondVar értéke: {0}", secondVar);

            // Új érték hozzárendelése:
            firstVar = 1010;
            secondVar = 2020;

            // Új érték kiírása
            Console.WriteLine("\nfirstVar új értéke: {0}", firstVar);
            Console.WriteLine("secondVar új értéke: {0}", secondVar);

            Console.ReadKey();
        }
    }
    */

    /* Chars
    class Chars
    {
        public static void Main()
        {
            int ctr;
            char ch;

            Console.WriteLine("\nNumber \t Value\n");

            for(ctr = 63; ctr <= 94; ctr = ctr + 1)
            {
                ch = (char) ctr;
                Console.WriteLine("{0}    is    {1}", ctr, ch);
            }
            Console.ReadKey();
        }
    }
    */

    /* Gyak1
    class Gyak1
    {
        static void Main()
        {
            int ctr;

            for (ctr = 1; ctr <= 10; ctr++)
            {
                Console.Write("{0:D3} ", ctr);
            }
            Console.ReadKey();
        }
    }
    */

    // Day 3 ***      *          *

    /* Pie
    class Pie
    {
        static void Main()
        {
            int forMe = 0;
            int piecesOfPie = 0;

            piecesOfPie = 3 * 6;
            forMe = piecesOfPie % 13;

            Console.WriteLine("Szeletek száma: {0} db", piecesOfPie);
            Console.WriteLine("Nekem jut: {0} db", forMe);
            Console.ReadKey();
        }
    }
    */

    /* prePost
    class prePost
    {
        static void Main()
        {
            int a = 1;
            int b = 1;

            Console.WriteLine("Kiinduló értékek: a = {0}, b = {1}", a, b);
            Console.WriteLine("Az a-t kiírjuk, majd növeljük eggyel, a b-t növeljük eggyel, majd kiírjuk.");
            Console.WriteLine();
            Console.WriteLine("a++: {0}, ++b: {1}", a++, ++b);  // Az a-t kiírjuk, majd növeljük eggyel, a b-t növeljük eggyel, majd kiírjuk
            Console.WriteLine("a++: {0}, ++b: {1}", a++, ++b);
            Console.WriteLine("a++: {0}, ++b: {1}", a++, ++b);
            Console.WriteLine();
            Console.WriteLine("a--: {0}, --b: {1}", a--, --b);
            Console.WriteLine("a--: {0}, --b: {1}", a--, --b);
            Console.WriteLine("a--: {0}, --b: {1}", a--, --b);
            Console.WriteLine();
            Console.WriteLine("Végső értékek: a: {0}, b: {1}", a, b);

            Console.ReadLine();
        }
    }
    */

    /* ifTest
class ifTest
{
    static void Main()
    {
        int a = 1;
        int b = 0;

        Console.WriteLine("IF parancs:");

        if (a == b) // Ha itt kiteszem a pontosvesszőt (hibásan), akkor lefut az IF parancs akkor is, ha a feltétetl nem teljesül
        {
            Console.WriteLine("Az a egyenlő b, tehát az IF feltétel teljesült, azaz IGAZ volt, így lefutott az IF parancs.");
        }
        Console.WriteLine("IF utáni rész.");
        Console.ReadKey();
    }
}
      */

    /* ifTest2
    class ifTest2
    {
        static void Main()
        {
            int day = 4;
            char sex = 'f';

            Console.WriteLine("Teszt indítása.. (day: {0}, sex: {1})", day, sex);
            Console.WriteLine();

            if (day >= 1 && day <= 7)
            {
                Console.WriteLine("Day 1-7 -ig");
            }

            if (sex == 'm' || sex == 'f')
            {
                Console.WriteLine("Sex \"m\" vagy \"f\"");
            }
            Console.WriteLine();
            Console.WriteLine("IF utáni rész.");
            Console.ReadKey();
        }
    }
    */

    /* ifShort
    class ifShort
    {
        static void Main()
        {
            int a = 1;
            int b = 0;
            int allitas;

            allitas = (a == b) ? 1 : 0;
            Console.WriteLine("Az állítás: {0}", allitas);
            Console.WriteLine("mert a = {0}, és b = {1}.",a, b);
            Console.ReadKey();
        }
    }
    */

    // Day 4 ****     *          *

    /* ifElse
    class ifElse
    {
        static void Main()
        {
            char gender = 'z';

            if (gender == 'm' || gender == 'f')
            {
                Console.WriteLine("The gender is valid: {0}.", gender);
            }
            else
            {
                Console.WriteLine("The gender is NOT valid: {0}.", gender);
            }
            Console.WriteLine();
            Console.WriteLine("Az IF vége.");
            Console.ReadKey();
        }
    }
    */

    /* nested IF
    class ifElse2
    {
        static void Main()
        {
            char gender = 'f';

            if (gender == 'm')
            {
                Console.WriteLine("The gender is valid: {0}.", gender);
            }
            else
            {
                if (gender == 'f')
                {
                    Console.WriteLine("The gender is valid: {0}.", gender);
                }
                else
                {
                    Console.WriteLine("The gender is unknown: {0}.", gender);
                }
            }
            Console.WriteLine();
            Console.WriteLine("Az IF vége.");
            Console.ReadKey();
        }
    }
    */

    /* switch
    class dice
    {
        static void Main()
        {
            Random rnd = new Random();
            int dice = rnd.Next(1, 7);  // Next() - Returns a non-negative random integer.

            Console.WriteLine("Starting the switch..");

            switch (dice)
            {
                case 1:
                    Console.WriteLine("Egy");
                    break;
                case 2:
                    Console.WriteLine("Kettő");
                    break;
                case 3:
                    Console.WriteLine("Három");
                    break;
                case 4:
                    Console.WriteLine("Négy");
                    break;
                case 5:
                    Console.WriteLine("Öt");
                    break;
                case 6:
                    Console.WriteLine("Hat");
                    break;
                default:
                    Console.WriteLine("Alapértelmezett érték");
                    break;
            }

            Console.WriteLine("Switch vége");
            Console.ReadLine();
        }
    }
    */

    /* switch Paros-e
    class OddEven_1
    {
        static void Main()
        {
            Random rnd = new Random();
            int dice = rnd.Next(1, 7);  // Next() - Returns a non-negative random integer.

            Console.WriteLine("Starting the switch..");

            switch (dice)
            {
                case 1:
                case 3:
                case 5:
                    Console.WriteLine("Páratlan - Odd");
                    break;

                case 2:
                case 4:
                case 6:
                    Console.WriteLine("Páros - Even");
                    break;
                default:
                    Console.WriteLine("Alapértelmezett érték");
                    break;
            }

            Console.WriteLine("Switch vége");
            Console.ReadLine();
        }
    }
    */

    /* while átlagszámítás
    class avarage
    {
        static void Main()
        {
            int osszeg = 0; // ttl - total
            int szam = 0; // nbr - number
            int szamlalo = 0; // ctr - counter

            Random rnd = new Random(); // Véletlen szám létrehozása

            while (szamlalo < 10)
            {
                szam = (int) rnd.Next(1, 101);
                Console.WriteLine("{0}. szám: {1}", (szamlalo + 1), szam);

                osszeg += szam; //özzseg = összeg + szam
                szamlalo++; // szamlalo = szamlalo + 1
            }

            Console.WriteLine("\nA {0} szám összege: {1}.", szamlalo, osszeg);
            Console.WriteLine("\nA számok átlaga: {0}.", osszeg/szamlalo);

            Console.ReadKey();
        }
    }
    */

    /* while paros-e
    class even
    {
        static void Main()
        {
            int ctr = 0; //counter

            while (true)
            {
                ctr++;

                if (ctr > 10)
                {
                    break;
                }
                else if ((ctr % 2) == 1)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("...{0}...", ctr);
                }
            }
            Console.WriteLine();
            Console.WriteLine("Kész!");
            Console.ReadKey();
        }
    }
    */

    /* do while átlagszám
    class do_it
    {
        static void Main()
        {
            int ttl = 0;
            int nbr = 0;
            int ctr = 0;

            Random rnd = new Random();

            do
            {
                nbr = (int)rnd.Next(1, 11);
                ctr++;
                ttl += nbr;

                Console.WriteLine("{0}. szám: {1}.", ctr, nbr);
            } while (nbr != 5);

            Console.WriteLine("\n{0} szám lett generálva.", ctr);
            Console.WriteLine("A számok összege: {0}.", ttl);
            Console.WriteLine("A számok átlaga: {0}.", ttl/ctr);
            Console.ReadKey();
        }
    }
    */


}