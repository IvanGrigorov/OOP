/* Define a class Student, which contains data about a student – first, middle and last name, SSN, permanent address, 
   mobile phone e-mail, course, specialty, university, faculty. Use an enumeration for the specialties, universities and faculties.
   Override the standard methods, inherited by System.Object: Equals(), ToString(), GetHashCode() and operators == and !=.
 
   Add implementations of the ICloneable interface. The Clone() method should deeply copy all object's fields into a new 
   object of type Student.
 
   Implement the IComparable<Student> interface to compare students by names (as first criteria, in lexicographic order) and by social 
   security number (as second criteria, in increasing order).
 
   Create a class Person with two fields – name and age. Age can be left unspecified (may contain null value. 
   Override ToString() to display the information of a person and if age is not specified – to say so.
   Write a program to test this functionality.*/


namespace StudentsAndPersons
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    class StudentsAndPersons
    {
        static void Main(string[] args)
        {
            Person personWithNotSpecifiedAge = new Person("Ivan", null);
            Person personWithSpecifiedAge = new Person("Ivan", 19);

            Console.WriteLine("Tests for Person class. "); 
            Console.WriteLine();
            Console.WriteLine("Person without specified age.");
            Console.WriteLine(personWithNotSpecifiedAge.ToString());
            Console.WriteLine();
            Console.WriteLine("Person with specified age. ");
            Console.WriteLine(personWithSpecifiedAge.ToString());
            Console.WriteLine();

            Student student = new Student("Ivan", "Ivanov", "Ivanov", 123456789, "Sofia, Mladost 1", "02/920 2020", "IIvanov@abv.bg",
                9, SpecialtiesEnumeration.SoftwareDevelopment, UniversitiesEnumeration.TechnicalUniversitySofia, 
                FacultiesEnumeration.ComputerDepartment);

            // We need to cast the clone as a Student because the clone method returns object
            // and == operator works only with two Student types variables
            // so var don't work here because var will be object
            Student copiedStudent = student.Clone() as Student;

            Student studentForComparison = new Student("Pantaley", "Panteleev", "pantaleev", 1234567123, "Sofia, Nadezda 1", "02/920 3330", "PPantaleev@abv.bg",
                10, SpecialtiesEnumeration.SoftwareEngineering, UniversitiesEnumeration.SofiaUniversity,
                FacultiesEnumeration.SoftwareDepartment);
            Console.WriteLine("Tests for the Student class.");
            Console.WriteLine();
            Console.WriteLine("The first student is :");
            Console.WriteLine(student.ToString());
            Console.WriteLine();
            Console.WriteLine("Its clone is :");
            Console.WriteLine(copiedStudent.ToString());
            Console.WriteLine();
            Console.WriteLine("The third student is :");
            Console.WriteLine(studentForComparison.ToString());
            Console.WriteLine();
            Console.WriteLine("Check the Equals method.");
            Console.WriteLine("The student and his clone are equal so it should return true");
            Console.WriteLine(student.Equals(copiedStudent));
            Console.WriteLine();
            Console.WriteLine("Check the == operator.");
            Console.WriteLine("The student and his clone are equal so it should return true");
            Console.WriteLine(student == copiedStudent);
            Console.WriteLine();
            Console.WriteLine("The unique hash codes of the two different students are :");
            Console.WriteLine(student.GetHashCode().ToString());
            Console.WriteLine(studentForComparison.GetHashCode().ToString());
            Console.WriteLine();
            Console.WriteLine("Comparing Students Ivan and Pantaley.");
            Console.WriteLine("Ivan is before Panataley so it should return -1");
            Console.WriteLine(student.CompareTo(studentForComparison).ToString());
        }
    }
}
