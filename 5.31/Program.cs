using System;

namespace _5._31
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = 2 * a;
            int c = 0;
            for (int i = a; a <= b; a++)
                c += a * a;
            Console.WriteLine(c);
        }
    }
}
