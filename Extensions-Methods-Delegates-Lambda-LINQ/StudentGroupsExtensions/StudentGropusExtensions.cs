/* Create a List<Student> with sample students. Select only the students that are from group number 2.
   Use Lambda Expressions. Order the students by FirstName.*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Student;

namespace StudentGropusExtensions
{
    class StudentGropusExtensions
    {
        static void Main(string[] args)
        {
            List<StudentClass> listStudents = new List<StudentClass>();
            listStudents.Add(new StudentClass("Ivan", "Novoselski", 20312, 029345678, "blablabla@gmail.com", 2, 21));
            listStudents.Add(new StudentClass("Marto", "Gradski", 20313, 029359678, "blablabla2@gmail.com", 1, 24));
            listStudents.Add(new StudentClass("Kaloyan", "Trunski", 20315, 029345696, "blablabla3@gmail.com", 3, 19));
            listStudents.Add(new StudentClass("Simeon", "Kalingradski", 20316, 029345656, "blablabla4@gmail.com", 2, 25));
            // Using Lambda Expressions for this ordering because I'am supposed to do so
            var byGroupSelection = listStudents
                .Where(student => student.GroupNumber == 2)
                .OrderBy(student => student.FirstName);
            foreach (StudentClass student in byGroupSelection)
            {
                Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
            }
        }
    }
}
