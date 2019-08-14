using System;

namespace TrekantArealOmkreds
{
    class Program
    {
        static void Main(string[] args)
        {
            string højde, grund;
            double højde1, grund1, areal, omkreds;
            Console.WriteLine("Hvad er højden og grundlinjen i din trekant?");

            højde = Console.ReadLine();
            grund = Console.ReadLine();

            højde1 = float.Parse(højde);
            grund1 = float.Parse(grund);

            //Beregning
            areal = (højde1 * grund1)/2;

            Console.WriteLine("Arealet af din trekant er {0}", areal);

            Console.WriteLine("Hvad er A, B og C?");
            string a, b, c;
            double a1, b2, c3;

            a = Console.ReadLine();
            b = Console.ReadLine();
            c = Console.ReadLine();

            a1 = float.Parse(a);
            b2 = float.Parse(b);
            c3 = float.Parse(c);

            //Beregning

            omkreds = a1 + b2 + c3;

            Console.Write("Omkredsen er {0}", omkreds);


        }
    }
}
