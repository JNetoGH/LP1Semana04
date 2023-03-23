using System;

namespace Power2Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("until 5: ");
            PowersOf2Until5();
            
            Console.WriteLine("\nuntil 3: ");
            PowersOf2UntilN(3);
            
            Console.WriteLine("\nuntil 2: ");
            PowersOf2UntilN(2);
        }
        
        // 0b_1 << 5 == ob_000001 == 35(10)
        private static void PowersOf2Until5() => PowersOf2UntilN(5);
        
        private static void PowersOf2UntilN(int n)
        {
            for (int i = 1; i <= (1 << n); i = i << 1)
                Console.WriteLine(i);
        }
    }
}