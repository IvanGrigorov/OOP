/* Extract all students with phones in Sofia.
   Use LINQ.*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Student;

namespace ExtractStudentsByPhone
{
    class ExtractStudentsByPhone
    {
        static void Main(string[] args)
        {
            List<StudentClass> listStudents = new List<StudentClass>();
            listStudents.Add(new StudentClass("Ivan", "Novoselski", 20312, "02/9345678", "blablabla@abv.bg", 2, 21));
            listStudents.Add(new StudentClass("Marto", "Gradski", 20313, "02/9359678", "blablabla2@gmail.com", 1, 24));
            listStudents.Add(new StudentClass("Kaloyan", "Trunski", 20315, "03/9345696", "blablabla3@abv.bg", 3, 19));
            listStudents.Add(new StudentClass("Simeon", "Kalingradski", 20316, "03/9345656", "blablabla4@gmail.com", 2, 25));
            // Using LINQ for this 
            // First way is to find if there is "02" sequence in front of the string number
            var phoneExtract =
                from student in listStudents
                where (student.Telephone).IndexOf("02") == 0
                select student;
            // Print the first selection
            foreach (StudentClass student in phoneExtract)
            {
                Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
            }
            Console.WriteLine();

            // Using LINQ for this 
            // Second way is to find if the first two chars of the string number are '0' and '2'
            var phoneExtractSecondWay =
                from student in listStudents
                where student.Telephone[0] == '0' 
                where student.Telephone[1] == '2'
                select student;
            // Print the second selection
            foreach (StudentClass student in phoneExtractSecondWay)
            {
                Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
            }
        }
    }
}
