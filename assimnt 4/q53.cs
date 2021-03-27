using System;

namespace q53
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 20, y = 35;
            x = y++ + ++x;
            y = ++y + ++x;
            Console.Write(x);
            Console.WriteLine(y);

            int x1 = 10, y1 = 15;
            x1 = ++x1;
            y1 = ++y1;
            Console.WriteLine(x1 + "," + y1);

            int a = 10;
            a++;
            Console.WriteLine(a);

            int a1 = 10;
            Console.WriteLine(a1++);

            int n = 10;
            int x3 = 0;
            x3 = n--;
            Console.WriteLine(x3);

            int i = 5, j = 6, k = 7, n2 = 3;
            Console.WriteLine(i + j * k - k % n2);

            int a2 = 6;
            Console.WriteLine(a2);
            a2 = a2 + 3;
            Console.WriteLine(a2);
            a2 = 5;
            Console.WriteLine(a2);
            a2++;
            Console.WriteLine(a);


        }
    }
}
