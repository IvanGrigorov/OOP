/* Implement an extension method Substring(int index, int length) for the class StringBuilder 
   that returns new StringBuilder and has the same functionality as Substring in the class String.*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubstringExtended
{
    public static class SubstringExtended
    {
        static void Main(string[] args)
        {
            StringBuilder test = new StringBuilder();
            test.Append('1');
            test.Append('2');
            test.Append('3');
            test.Append('4');
            test.Append('5');
            StringBuilder result = test.Substring(1, 4); // Simple Test
            Console.WriteLine(result.ToString());
        }

        public static StringBuilder Substring(this StringBuilder stringBuilder, int index, int length)
        {
            StringBuilder result = new StringBuilder();
            for (int i = index; i <= index + length - 1 ; i++)
            {
                result.Append(stringBuilder[i]);
            }
            return result;
        }
    }
}
