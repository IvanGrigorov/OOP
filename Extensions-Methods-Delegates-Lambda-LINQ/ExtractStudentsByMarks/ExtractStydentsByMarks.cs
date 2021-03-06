﻿/* Select all students that have at least one mark Excellent (6) into a new anonymous class that has properties – FullName and Marks.
   Use LINQ.*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Student;

namespace ExtractStydentsByMarks
{
    class ExtractStydentsByMarks
    {
        static void Main(string[] args)
        {
            List<StudentClass> listStudents = new List<StudentClass>();
            listStudents.Add(new StudentClass("Ivan", "Novoselski", 20312, 029345678, "blablabla@abv.bg", 2, 21));
            listStudents.Add(new StudentClass("Marto", "Gradski", 20313, 029359678, "blablabla2@gmail.com", 1, 24));
            listStudents.Add(new StudentClass("Kaloyan", "Trunski", 20315, 029345696, "blablabla3@abv.bg", 3, 19));
            listStudents.Add(new StudentClass("Simeon", "Kalingradski", 20316, 029345656, "blablabla4@gmail.com", 2, 25));

            // Adding different Notes for the example
            // Ivan has two 6 marks
            listStudents[0].Marks.Add(5);
            listStudents[0].Marks.Add(6);
            listStudents[0].Marks.Add(5);
            listStudents[0].Marks.Add(6);

            // Marto has one 6 mark
            listStudents[1].Marks.Add(4);
            listStudents[1].Marks.Add(4);
            listStudents[1].Marks.Add(3);
            listStudents[1].Marks.Add(6);

            // Kaloyan has one 6 mark
            listStudents[2].Marks.Add(6);
            listStudents[2].Marks.Add(4);
            listStudents[2].Marks.Add(5);
            listStudents[2].Marks.Add(3);

            // Simeon has no 6 marks so he shouldn't be added
            listStudents[3].Marks.Add(3);
            listStudents[3].Marks.Add(3);
            listStudents[3].Marks.Add(4);
            listStudents[3].Marks.Add(5);

            // Using LINQ for this 
            var markExtract =
                from student in listStudents
                where  student.Marks.Any(mark => mark == 6) // Combining Lambda with LINQ to make the right preicate (the method Any wants an extension method as predicate)
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
