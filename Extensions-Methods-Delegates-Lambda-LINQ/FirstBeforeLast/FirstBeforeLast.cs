﻿/* Write a method that from a given array of students finds all students whose first name is before its last name alphabetically.
   Use LINQ query operators.*/

/* Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Student;

namespace FirstBeforeLast
{
    
    class FirstBeforeLast
    {
        static void Main(string[] args)
        {
            StudentClass[] sequenceStudents = {new StudentClass("Ivan", "Novoselski", 20312, 029345678, "blablabla@gmail.com" ,2, 21), 
                new StudentClass("Marto", "Gradski", 20313, 029359678, "blablabla2@gmail.com",1 ,24), 
                new StudentClass("Kaloyan", "Trunski", 20315, 029345696, "blablabla3@gmail.com",3 ,19),
                new StudentClass("Simeon", "Kalingradski", 20316, 029345656, "blablabla4@gmail.com", 2, 25)};

            var firstBeforeLast = sequenceStudents
                .Where(student => (student.FirstName).CompareTo(student.LastName) <= 0);

            foreach (StudentClass student in firstBeforeLast)
            {
                Console.WriteLine("{0} {1}",student.FirstName, student.LastName);
            }
        }
    }
}
