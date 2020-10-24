using System;
using System.Collections.Generic;
using System.Text;

namespace TestMaximum
{
   public class Generic<T> where T : IComparable
    {
         T[] numbers;

        /// <summary>
        /// Initializes a new instance of the <see cref="MaximumTester{T}"/> class.
        /// </summary>
        /// <param name="entries">The entries.</param>
        public Generic(T[] numbers)
        {
            this.numbers = numbers;
        }

        /// <summary>
        /// Tests the maximum.
        /// </summary>
        /// <returns></returns>
        public T TestMaximum()
        {
            return GetMaxNumber(numbers);
        }
       /// <summary>
       /// This method returns the max number among given numbers
       /// </summary>
       /// <param name="numbers"></param>
       /// <returns></returns>
        private T GetMaxNumber(T[] numbers)
        {
            Array.Sort(numbers);
            Array.Reverse(numbers);
            PrintMax(numbers[0]);
            return numbers[0];
        }

        /// <summary>
        /// Prints the maximum.
        /// </summary>
        /// <param name="maxValue">The maximum value.</param>
        private void PrintMax(T maxValue)
        {
            Console.WriteLine("The maximum number is:",numbers[0]);
        }
    }
}
