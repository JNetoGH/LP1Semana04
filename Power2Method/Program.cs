using System;

namespace Power2Method
{
    class Program
    {
        /// <summary>
        /// This method is the entry point of the program 
        /// </summary>
        /// <param name="args">passed at the Project execution (Not Required to This Program)</param>
        static void Main(string[] args)
        {
            Console.WriteLine("\nuntil 5: ");
            PowersOf2Until5();
            
            Console.WriteLine("\nuntil 3: ");
            PowersOf2UntilN(3);
            
            Console.WriteLine("\nuntil 2: ");
            PowersOf2UntilN(2);
        }
        
        /// <summary>
        /// Prints on the console, the powers of 2 until 5: (0 to 5)
        /// </summary>
        private static void PowersOf2Until5() => PowersOf2UntilN(5);
        
        /// <summary>
        /// Prints on the console, the powers of 2 until N
        /// </summary>
        /// <param name="n">Represents the end of the range of powers of 2 to be printed: (0 to N)</param>
        private static void PowersOf2UntilN(int n)
        {
            for (int i = 1; i <= (1 << n); i = i << 1)
                Console.WriteLine(i);
        }
        
    }
}