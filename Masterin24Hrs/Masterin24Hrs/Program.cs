using System;

namespace Masterin24Hrs
{
    class Area  // Kör területének számítása
    {
        static void Main()
        {
            // Változók bevezetése
            int radius = 4;     // sugár, r
            const double pi = 3.14159;      // pí
            double area;    // terület

            // Számítás (kör területe = r négyzet * pí)
            area = (radius * radius) * pi;

            // Eredmény kiírása
            Console.WriteLine("Sugár: {0}, Pí: {1}", radius, pi);
            Console.WriteLine("A köre területe: {0}", area);
            Console.ReadKey();
        }
    }
}
