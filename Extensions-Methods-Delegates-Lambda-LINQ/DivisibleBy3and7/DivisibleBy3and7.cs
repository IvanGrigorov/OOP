/* Write a program that prints from given array of integers all numbers that are divisible by 7 and 3. 
   Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivisibleBy3and7
{
    class DivisibleBy3and7
    {
        static void Main(string[] args)
        {
            int[] intTest = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 21, 42 };

            // Using Lambda
            var divisibleWithLambda = intTest
                .Where(number => (number % 7 == 0 &&
                                  number % 3 == 0));

            // sequence with Lambda expressions
            foreach (int number in divisibleWithLambda)
            {
                Console.Write("{0} ", number);
            }
            Console.WriteLine();
            // Using LINQ 
            var divisibleWithLINQ =
                from number in intTest
                where number % 7 == 0
                where number % 3 == 0
                select number;

            // sequence with LINQ expressions
            foreach (int number in divisibleWithLINQ)
            {
                Console.Write("{0} ", number);
            }
            Console.WriteLine();
        }
    }
}
