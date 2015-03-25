/* Write a program to return the string with maximum length from an array of strings.
   Use LINQ.*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestString
{
    class LongestString
    {
        static void Main(string[] args)
        {
            string[] stringTest = { "P", "PE", "PER", "PERS", "PERSO", "PERSON" };

            var result =
                from tmpString in stringTest
                where tmpString == stringTest.Max()
                select tmpString;

            foreach (string tmpString in result)
            {
                Console.WriteLine(tmpString); // It will print the only value in the Collection which hopefully will be the maximum string  
            }
        }
    }
}
