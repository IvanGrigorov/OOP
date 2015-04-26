/* Define a class BitArray64 to hold 64 bit values inside an ulong value.
   Implement IEnumerable<int> and Equals(…), GetHashCode(), [], == and !=.*/


namespace _64BitArray
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    class _64BitArray
    {
        static void Main(string[] args)
        {
            BitArray64 array = new BitArray64(123456789);
            BitArray64 anotherArray = new BitArray64(2343513153);
            BitArray64 thirdArray = new BitArray64(123456789);

            Console.WriteLine("Check the Equals method.");
            Console.WriteLine("The arrays are not equal so it should return false");
            Console.WriteLine(array.Equals(anotherArray));
            Console.WriteLine();
            Console.WriteLine("Check the == operator.");
            Console.WriteLine("The arrays are equal so it should return true");
            Console.WriteLine(array == thirdArray);
            Console.WriteLine();
            Console.WriteLine("Testing the index.");
            Console.WriteLine("Printing the 3 - rd element of the first array. It is 3");
            Console.WriteLine(array[2].ToString());
            Console.WriteLine();
            Console.WriteLine("The unique hash codes of the three arays are :");
            Console.WriteLine(array.GetHashCode().ToString());
            Console.WriteLine(anotherArray.GetHashCode().ToString());
            Console.WriteLine(thirdArray.GetHashCode().ToString());
            Console.WriteLine();
            Console.WriteLine("Printing the third array sequence and testing the foreach loop. ");
            foreach (var digit in thirdArray)
            {
                Console.Write("{0} ", digit.ToString());
            }
            Console.WriteLine();

        }
    }
}
