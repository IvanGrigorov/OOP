/* Extract all Marks of the students that enrolled in 2006. 
   (The students from 2006 have 06 as their 5-th and 6-th digit in the FN).*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Student;

namespace ExtractMarks
{
    class ExtractMarks
    {
        static void Main(string[] args)
        {
            List<StudentClass> listStudents = new List<StudentClass>();
            listStudents.Add(new StudentClass("Ivan", "Novoselski", 203106, 029345678, "blablabla@abv.bg", 2, 21)); // He is from 2006
            listStudents.Add(new StudentClass("Marto", "Gradski", 2031307, 029359678, "blablabla2@gmail.com", 1, 24)); // He is from 2007 so he shouldn't be added
            listStudents.Add(new StudentClass("Kaloyan", "Trunski", 203106, 029345696, "blablabla3@abv.bg", 3, 19)); // He is from 2006
            listStudents.Add(new StudentClass("Simeon", "Kalingradski", 2031608, 029345656, "blablabla4@gmail.com", 2, 25)); // He is from 2008 so he shouldn't be added

            // Adding different Notes for the example
            // Ivan's marks
            listStudents[0].Marks.Add(5);
            listStudents[0].Marks.Add(6);
            listStudents[0].Marks.Add(5);
            listStudents[0].Marks.Add(6);

            // Marto's marks
            listStudents[1].Marks.Add(4);
            listStudents[1].Marks.Add(2);
            listStudents[1].Marks.Add(2);
            listStudents[1].Marks.Add(6);

            // Kaloyan's marks  
            listStudents[2].Marks.Add(6);
            listStudents[2].Marks.Add(4);
            listStudents[2].Marks.Add(2);
            listStudents[2].Marks.Add(3);

            // Simeon's marks
            listStudents[3].Marks.Add(3);
            listStudents[3].Marks.Add(2);
            listStudents[3].Marks.Add(5);
            listStudents[3].Marks.Add(2);

            // Using LINQ for this 
            var markExtract =
                from student in listStudents
                where ((student.FN).ToString()).IndexOf("06") == 4 // The way is to find if there is "06" sequence on the 4 - 5 index of the string number
                select new { student.FirstName, student.Marks }; // Adding them to a list with anonymous classes with two 
                                                                 // properties FirstName and Marks

            // Printing the selection
            foreach (var student in markExtract)
            {
                Console.Write("{0} has marks ", student.FirstName);
                foreach (int mark in student.Marks)
                {
                    Console.Write("{0} ", mark.ToString());
                }
                Console.WriteLine();
            }
        }
    }
}
