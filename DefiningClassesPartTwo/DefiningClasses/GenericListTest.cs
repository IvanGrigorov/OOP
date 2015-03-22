/*Test for the Generic List*/


//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DefiningClasses
//{
//    class GenericListTest
//    {
//        static void Main()     // To run another Main you need to comment this one
//        {                      // and uncomment the one you want to work. There can be only one compiled Main in a programm. 
//            GenericList<int> intList = new GenericList<int>(3);
//            Console.WriteLine("INTEGER LIST");
//            Console.WriteLine("The list after initializing it: ");
//            Console.WriteLine(intList.ToString());
//            intList.Add(3);
//            Console.WriteLine("The list after adding 3: ");
//            Console.WriteLine(intList.ToString());
//            intList.Add(-5);
//            Console.WriteLine("The list after adding -1: ");
//            Console.WriteLine(intList.ToString());
//            intList.Insert(1, 6);
//            Console.WriteLine("The list after inserting 2 at position 1: ");
//            Console.WriteLine(intList.ToString());
//            Console.WriteLine("The smallest element in the list: {0}", (GenericList<int>.Min(intList)).ToString());
//            Console.WriteLine("The largest element in the list: {0}", (GenericList<int>.Max(intList)).ToString());
//            Console.WriteLine(intList.ToString());
//            Console.WriteLine(intList.ToString());
//            intList.Delete(0);
//            Console.WriteLine("The list after removing the element at position 0: ");
//            Console.WriteLine(intList.ToString());
//            intList.Clear();
//            Console.WriteLine("The list after clearing it: ");
//            Console.WriteLine(intList.ToString());

//            GenericList<string> stringList = new GenericList<string>(3);
//            Console.WriteLine("\nSTRING LIST");
//            Console.WriteLine("The list after initializing it: ");
//            Console.WriteLine(stringList.ToString());
//            stringList.Add("What's ");
//            Console.WriteLine("The list after adding \"What's\": ");
//            Console.WriteLine(stringList.ToString()); ;
//            stringList.Insert(0, "Hey! Yeah ");
//            Console.WriteLine("The list after inserting \"Hey! Yeah\" at position 0: ");
//            Console.WriteLine(stringList.ToString());
//            stringList.Add("Up?");
//            Console.WriteLine("The list after adding \"Up\": ");
//            Console.WriteLine(stringList.ToString());
//            Console.WriteLine("The smallest element in the list: {0}", (GenericList<string>.Min(stringList)).ToString());
//            Console.WriteLine("The largest element in the list: {0}", (GenericList<string>.Max(stringList)).ToString());
//            stringList.Delete(0);
//            Console.WriteLine("The list after removing the element at position 0: ");
//            Console.WriteLine(stringList.ToString());
//            stringList.Clear();
//            Console.WriteLine("The list after clearing it: ");
//            Console.WriteLine(stringList.ToString());
//        }
//    }
//}
