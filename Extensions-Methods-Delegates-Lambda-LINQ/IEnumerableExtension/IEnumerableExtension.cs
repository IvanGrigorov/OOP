/* Implement a set of extension methods for IEnumerable<T> that implement the following group functions: 
   sum, product, min, max, average.*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableExtension
{
    public static class IEnumerableExtension
    {
        static void Main(string[] args)
        {
            string[] stringTest = { "P", "E", "R", "S", "O", "N" };
            int[] intTest = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            ulong[] ulongTest = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            // Test for sum of integers
            Console.WriteLine(intTest.FindingSum());
            // Test for sum of strings
            Console.WriteLine(stringTest.FindingSum());
            // Test for product of ulongs
            Console.WriteLine(ulongTest.Product());
            // This test is not executed because you can't multiply strings
            //Console.WriteLine(stringTest.Product());
            // Finding the min value among integers
            Console.WriteLine(intTest.MinValue());
            // Finding the min value among strings
            Console.WriteLine(intTest.MaxValue());
            // Finding the max value among integers
            Console.WriteLine(stringTest.MinValue());
            // Finding the max value among strings
            Console.WriteLine(stringTest.MaxValue());
            // Finding the average of a sequence of integers
            Console.WriteLine(intTest.Average());
                
        }

        public static T FindingSum<T>(this IEnumerable<T> enumeration)
        {
            T sum = default(T);
            foreach (T enumerated in enumeration)
            {
                sum += (dynamic)enumerated;
            }
            return sum;
        }
        public static ulong Product<T>(this IEnumerable<T> enumeration)
        {
            ulong product = 1;
            foreach (T enumerated in enumeration)
            {
                product *= (dynamic)enumerated;
            }
            return product;
        }
        public static T MinValue<T>(this IEnumerable<T> enumeration) where T : IComparable
        {
            T min = enumeration.Min();          
            return min;
        }
        public static T MaxValue<T>(this IEnumerable<T> enumeration) where T : IComparable
        {
            T max = enumeration.Max();
            return max;
        }
        public static double Average<T>(this IEnumerable<T> enumeration)
        {
            double average = 0;
            int length = 0;
            T sum = default(T);
            foreach (T enumerated in enumeration)
            {
                sum += (dynamic)enumerated;
                length++;
            }
            average = (dynamic)sum / length;
            return average;
        }
    }
}
