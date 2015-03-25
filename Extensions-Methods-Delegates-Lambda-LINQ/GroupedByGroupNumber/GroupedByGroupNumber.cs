/* Create a program that extracts all students grouped by GroupNumber and then prints them to the console.
   Use LINQ.*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Student;

namespace GroupedByGroupNumber
{
    class GroupedByGroupNumber
    {
        static void Main(string[] args)
        {
            List<StudentClass> listStudents = new List<StudentClass>();
            listStudents.Add(new StudentClass("Ivan", "Novoselski", 20312, 029345678, "blablabla@gmail.com", 2, 21));
            listStudents.Add(new StudentClass("Marto", "Gradski", 20313, 029359678, "blablabla2@gmail.com", 1, 24));
            listStudents.Add(new StudentClass("Kaloyan", "Trunski", 20315, 029345696, "blablabla3@gmail.com", 3, 19));
            listStudents.Add(new StudentClass("Simeon", "Kalingradski", 20316, 029345656, "blablabla4@gmail.com", 2, 25));
            
            var byGroupSelection =
                from student in listStudents
                group student by student.GroupNumber;

            // Printing the result after grouping
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
    }
}
