using System;

namespace q59
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 22 / 8;
            Console.WriteLine(n);

            int n1 = 99 / 8 + 21 / 11 * 7;
            Console.WriteLine(n1);

            double a = 4, b = 3, q = 8, p = 2;
            double n2 = q / a - p / b;
            Console.WriteLine(n2);

            int a1 = 6, b1 = 3, q1 = 8, p1 = 2;
            double n3 = p1 / a1 + q1 / b1;
            Console.WriteLine(n3);

            int a2 = 3, b2 = 2, p2 = 8, q2 = 5;
            double n4 = p2 / b2 + q2 / a2;
            Console.WriteLine(n4);

            int n5 = 11 + 7 / 4 + 98 % 6 * 3;
            Console.WriteLine(n5);
            
        }
    }
}
