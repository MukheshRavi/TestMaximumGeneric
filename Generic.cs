using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace TestMaximum
{
    /// <summary>
    /// Generic class where datatype is defined
    ///  should extend interface-IComparable to call compareTo method.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Generic<T> where T : IComparable
    {
        //defining variables of generic type
       public T first;
       public T second;
       public T third;
        public Generic()
        {

        }
        /// <summary>
        /// parameter constructor to initialize variables
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <param name="third"></param>
        public Generic(T first, T second, T third)
        {
            this.first = first;
            this.second= second;
            this.third = third;
        }
        /// <summary>
        /// This method is used to internally call the GetMaxAmongThree function
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <param name="third"></param>
        public static void TestMaximum(T first, T second, T third)
        {
            ///Creating object to instantiate constructor and to call the method 
            T result = new Generic<T>(first, second, third). GetMaxAmongThree();
            ///Displaying Maximum Number returned from GetMaxAmongThree function
            Console.WriteLine(result);

        }

        /// <summary>
        /// This method is used to find out max among three by using generics, any data type can be provided
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <param name="third"></param>
        /// <returns></returns>
        public  T GetMaxAmongThree()
        {
            Console.WriteLine("Maximum Number");
            //compare to method is used to compare 2 numbers
            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0)
                return first;
            if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0)
                return second;
            if (third.CompareTo(second) > 0 && third.CompareTo(first) > 0)
                return third;
            else
            {
                throw new Exception("All 3 numbers are same");
            }
        }
       
    }
}
