/* Define a class InvalidRangeException<T> that holds information about an error condition related to invalid range. 
   It should hold error message and a range definition [start … end].
   Write a sample application that demonstrates the InvalidRangeException<int> and InvalidRangeException<DateTime> by 
   entering numbers in the range [1..100] and dates in the range [1.1.1980 … 31.12.2013].*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RangeExceptions
{
    class RangeExceptions
    {
        private static void CheckRange(int number)
        {
            InvalidRangeException<int> intException = new InvalidRangeException<int>
                ("The argument is out of range", 1, 100);
            if (number < 1 || number > 100)
            {
                throw intException;
            }
           
        }
        private static void CheckRange(DateTime date)
        {
            InvalidRangeException<DateTime> dateTimeException = new InvalidRangeException<DateTime>("The argument is out of range",
                new DateTime(1980, 01, 01), new DateTime(2013, 12, 31));
            if (date < new DateTime(1980, 01, 01) || date > new DateTime(2013, 12, 31))
            {
                throw dateTimeException;
            }
        } 

        static void Main(string[] args)
        {
            // Coment one try - catch to see the error of the other 

            //try
            //{
            //    CheckRange(1110);
            //}
            //catch (InvalidRangeException<int> ex)
            //{
            //    Console.WriteLine("The value is out of the range {0} and {1}", ex.Min, ex.Max);
            //    throw ex;
            //}

            try
            {
                CheckRange(new DateTime(2014, 05, 06));
            }
            catch (InvalidRangeException<DateTime> ex)
            {
                Console.WriteLine("The value is out of the range {0} and {1}", ex.Min.Date, ex.Max.Date);
                throw ex;
            }
        }
    }
}
