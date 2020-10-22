using System;
using System.Collections.Generic;
using System.Text;

namespace TestMaximum
{
    class Program
    {
        public static void Main(string[] args)
        {
            ///calling Non generic class methods
            Console.WriteLine(NonGeneric.GetMaxIntNumberAmongThree(13, 23, 45));
            Console.WriteLine( NonGeneric.GetMaxfloatNumberAmongThree(27.5f, 34.9f, 98.7f));
            Console.WriteLine(NonGeneric.GetMaxStringNumberAmongThree("asd", "cdf", "def"));
            ///Calling Genric class methods
            new Generic<int>(new int[]{34, 45, 56, 78}).TestMaximum();
        }
    }
}
