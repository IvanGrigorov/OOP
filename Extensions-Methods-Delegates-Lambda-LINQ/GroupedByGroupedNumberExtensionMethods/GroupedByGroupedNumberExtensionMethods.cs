/* Create a program that extracts all students grouped by GroupNumber and then prints them to the console.
   Using extension methods.*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Student;

namespace GroupedByGroupedNumberExtensionMethods
{
    public static class GroupedByGroupedNumberExtensionMethods
    {
        static void Main(string[] args)
        {
            List<StudentClass> listStudents = new List<StudentClass>();
            listStudents.Add(new StudentClass("Ivan", "Novoselski", 20312, 029345678, "blablabla@gmail.com", 2, 21));
            listStudents.Add(new StudentClass("Marto", "Gradski", 20313, 029359678, "blablabla2@gmail.com",1 ,24));
            listStudents.Add(new StudentClass("Kaloyan", "Trunski", 20315, 029345696, "blablabla3@gmail.com", 3, 19));
            listStudents.Add(new StudentClass("Simeon", "Kalingradski", 20316, 029345656, "blablabla4@gmail.com", 2, 25));

            // Printing the result from the custom method
            List<StudentClass>[] groups = listStudents.CustomGroup();
            Console.WriteLine("Using my custom extension method.");
            Console.WriteLine();
            for (int i = 0; i < groups.Length && groups[i] != null; i++)
            {
                Console.WriteLine("Group: ");
                Console.WriteLine();
                foreach (var student in groups[i])
                {
                    Console.WriteLine("{0} {1} {2}", student.FirstName, student.LastName, student.GroupNumber.ToString()); 
                }
                Console.WriteLine();
            }

            // Thereis also integrated grouping method GroupBy
            var byGroupSelection = listStudents
                 .GroupBy(student => student.GroupNumber);

            Console.WriteLine("Using the GroupBY method.");
            Console.WriteLine();
            foreach (var group in byGroupSelection)
            {
                Console.WriteLine("The groups are ordered by {0}", group.Key);
                Console.WriteLine();
                foreach (StudentClass student in group)
                {
                    Console.WriteLine("{0} {1} {2}", student.FirstName, student.LastName, student.GroupNumber.ToString());
                }
                Console.WriteLine();
            }
        }

        // I created my own method for grouping by group number
        public static List<StudentClass>[] CustomGroup(this List<StudentClass> list)
        {
            // Declaring an array from lists<StudentClass> which will contain the groups
            // The maximum size of the array is the Count of the list because there can't be more groups then the students
            List<StudentClass>[] result = new List<StudentClass>[list.Count]; 
            // This array contains the value of the group numbers
            int[] control = new int[list.Count];
            // With this index we controll the adding in the controll array 
            int controlIndeks = 0;
            for (int i = 0; i < list.Count; i++) // Check all the students in the list 
            {
                if (!control.Contains(list[i].GroupNumber)) // First check if we don't have alreday a student with this group number 
                {
                    control[controlIndeks] = list[i].GroupNumber; // We add the group number as already checked 
                    result[controlIndeks] = new List<StudentClass>(); // Declare new List from students with this group number 
                    result[controlIndeks].Add(list[i]); // Adding the first student with this group number
                    controlIndeks++; // Increasing the index to be ready for the next adding
                }
                else
                {
                    // Finding the index of the list with students with the needed grouo number
                    int tmpIndeks = Array.IndexOf(control, list[i].GroupNumber); // Finding the index of the list with students the needed 
                    result[tmpIndeks].Add(list[i]); // Adding the student to the existing list
                }
            }
            return result;
        }
    }
}
