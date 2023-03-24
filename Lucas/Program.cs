using System;

namespace Lucas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Lucas(0));
            Console.WriteLine(Lucas(2));
            Console.WriteLine(Lucas(7));

        }

        private static int Lucas(int n)
        {
            return n switch
            {
                0 => 2,
                1 => 1,
                _ => Lucas(n - 1) + Lucas(n - 2)
            };
        }
    }
}