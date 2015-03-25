/* Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students by first name and last name in descending order.
   Rewrite the same with LINQ.*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Student;

namespace OrderStudents
{
    class OrderStudent
    {
        static void Main(string[] args)
        {
            StudentClass[] sequenceStudents = {new StudentClass("Ivan", "Novoselski", 20312, 029345678, "blablabla@gmail.com" ,2, 21), 
                new StudentClass("Marto", "Gradski", 20313, 029359678, "blablabla2@gmail.com",1 ,24), 
                new StudentClass("Kaloyan", "Trunski", 20315, 029345696, "blablabla3@gmail.com",3 ,19),
                new StudentClass("Simeon", "Kalingradski", 20316, 029345656, "blablabla4@gmail.com", 2, 25)};

            // Orered with Lambda 
            var orderStudentsLambda = sequenceStudents
                .OrderByDescending(student => student.FirstName)
                .ThenByDescending(student => student.LastName);

            // sequence with Lambda expressions
            foreach (StudentClass student in orderStudentsLambda)
            {
                Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
            }
            Console.WriteLine();
            // Ordered with LINQ 
            var orderStudentsLINQ =
                from student in sequenceStudents
                orderby student.FirstName descending, student.LastName descending
                select student;
          
            // sequence with LINQ expressions
            foreach (StudentClass student in orderStudentsLINQ)
            {
                Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
            }
                
        }
    }
}
