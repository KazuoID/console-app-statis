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

            double g, h;
            g = Convert.ToDouble(10);
            h = Math.Sqrt(g);

            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(f);
            Console.WriteLine(h);
        }
    }
}

