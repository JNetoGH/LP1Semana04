﻿using System;

namespace Power2Method
{
    class Program
    {
        
        static void Main(string[] args)
        {
            PowersOf2Until5();
            PowersOf2Until5();
        }
        
        private static void PowersOf2Until5()
        {
            // 0b_1 << 5 == ob_000001 == 35(10)
            for (int i = 1; i <= (1 << 5); i = i << 1)
                Console.WriteLine(i);
        }
        
    }

}