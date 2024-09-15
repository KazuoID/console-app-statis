using System;

namespace statis
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, e, f;
            a = 20;
            b = 20;
            c = a + b;
            d = a - b;
            e = a * b;
            f = a / b;

            double g, h, i;
            g = Convert.ToDouble(10);
            h = Math.Sqrt(g);
            i = Math.Pow(g, 2);

            Console.WriteLine(c); //tambah (+)
            Console.WriteLine(d); //kurang (-)
            Console.WriteLine(e); //kali (*)
            Console.WriteLine(f); //bagi (/)
            Console.WriteLine(h); //akar
            Console.WriteLine(i); //pangkat
        }
    }
}
