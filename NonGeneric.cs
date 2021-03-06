﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TestMaximum
{
    public class NonGeneric
    {
        /// <summary>
        /// max of 3 integers using non generic method
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <param name="third"></param>
        /// <returns></returns>
        public static int GetMaxIntNumberAmongThree(int first, int second, int third)
        {
            Console.WriteLine("Maximum number among three numbers is:");
            //compare to method is used to compare 2 numbers
            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0)
            {
                return first;
            }
            if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0)
            {
                return second;
            }
            if (third.CompareTo(second) > 0 && third.CompareTo(first) > 0)
            {
                return third;
            }
            throw new Exception("All 3 numbers are same");
        }
        /// <summary>
        /// used to find max between 3 floats using non generic method
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <param name="third"></param>
        /// <returns></returns>
        public static float GetMaxfloatNumberAmongThree(float first, float second, float third)
        {
            Console.WriteLine("Maximum number");
            //compare to method is used to compare 2 numbers
            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0)
            {
                return first;
            }
            if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0)
            {
                return second;
            }
            if (third.CompareTo(second) > 0 && third.CompareTo(first) > 0)
            {
                return third;
            }
            throw new Exception("All 3 numbers are same");
        }
        /// <summary>
        ///  used to find max between 3 String Numbers using non generic method
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <param name="third"></param>
        /// <returns></returns>
        public static string GetMaxStringNumberAmongThree(string first, string second, string third)
        {
           
            Console.WriteLine("Maximum number");
            //compare to method is used to compare 2 numbers
            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0)
            {
                return first;
            }
            if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0)
            {
                return second;
            }
            if (third.CompareTo(second) > 0 && third.CompareTo(first) > 0)
            {
                return third;
            }
            throw new Exception("All 3 numbers are same");
        }
    }
}