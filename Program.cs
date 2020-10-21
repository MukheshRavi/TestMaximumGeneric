using System;
using System.Collections.Generic;
using System.Text;

namespace TestMaximum
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(NonGeneric.GetMaxIntNumberAmongThree(13, 23, 45));
            Console.WriteLine( NonGeneric.GetMaxfloatNumberAmongThree(27.5f, 34.9f, 98.7f));
            Console.WriteLine(NonGeneric.GetMaxStringNumberAmongThree("asd", "cdf", "def"));
            Generic<int>.TestMaximum(3, 6, 9);
        }
    }
}
