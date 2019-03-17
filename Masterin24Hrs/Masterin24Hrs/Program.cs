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

    // Day 3 ***

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
}