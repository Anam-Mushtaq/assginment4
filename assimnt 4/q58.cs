using System;

namespace q55
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            a = 2;
            b = 3;
            c = 5;
            Console.WriteLine(++a);

            Console.WriteLine(a++);

            Console.WriteLine(b += a);

            Console.WriteLine(b += a * c);

            Console.WriteLine(a += 2);
            Console.WriteLine(b = 2 / 2);

            Console.WriteLine(a++ + b++);

        }
    }
}
