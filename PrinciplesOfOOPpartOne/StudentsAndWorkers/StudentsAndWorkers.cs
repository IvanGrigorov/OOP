/* Define abstract class Human with a first name and a last name. Define a new class Student which is derived from Human 
   and has a new field – grade. Define class Worker derived from Human with a new property WeekSalary and WorkHoursPerDay 
   and a method MoneyPerHour() that returns money earned per hour by the worker. Define the proper constructors and properties 
   for this hierarchy.
   Initialize a list of 10 students and sort them by grade in ascending order (use LINQ or OrderBy() extension method).
   Initialize a list of 10 workers and sort them by money per hour in descending order.
   Merge the lists and sort them by first name and last name.*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAndWorkers
{
    class StudentsAndWorkers
    {
        static void Main(string[] args)
        {
            List<Student> listOfStudents = new List<Student>();
            listOfStudents.Add(new Student("Ivan", "Ivanchov", 5));
            listOfStudents.Add(new Student("Pesho", "Peshev", 5));
            listOfStudents.Add(new Student("Dragan", "Daraganov", 6));
            listOfStudents.Add(new Student("Nikolay", "Nikolov", 5));
            listOfStudents.Add(new Student("Sasho", "Sashev", 5));
            listOfStudents.Add(new Student("Milcho", "Milchev", 4));
            listOfStudents.Add(new Student("Liubomir", "Liubomirov", 4));
            listOfStudents.Add(new Student("Mihail", "Mihaylov", 4));
            listOfStudents.Add(new Student("Petyo", "Petyov", 3));
            listOfStudents.Add(new Student("Milko", "Milkov", 2));

            var studentsSelection = listOfStudents
                .OrderBy(student => student.Grade);

            Console.WriteLine("Oredered Students by grades.");
            Console.WriteLine();
            foreach (Student student in studentsSelection)
            {
                Console.WriteLine("{0} {1} {2}", student.FirstName, student.LastName, student.Grade.ToString());
            }
            Console.WriteLine();

            List<Worker> listOfWorkers = new List<Worker>();
            listOfWorkers.Add(new Worker("Ivan", "Ivanchov", 1800, 8));
            listOfWorkers.Add(new Worker("Kostadin", "Peshev", 1000, 7));
            listOfWorkers.Add(new Worker("Dragan", "Kostov", 800 , 7));
            listOfWorkers.Add(new Worker("Nikolay", "Mladenov", 2500, 8));
            listOfWorkers.Add(new Worker("Misho", "Sashev", 700, 8));
            listOfWorkers.Add(new Worker("Milcho", "Karagiozov", 600, 5));
            listOfWorkers.Add(new Worker("Liubomir", "Pashev", 1200, 7));
            listOfWorkers.Add(new Worker("Liubo", "Mihaylov", 1400, 8));
            listOfWorkers.Add(new Worker("Svilen", "Petyov", 2000, 8));
            listOfWorkers.Add(new Worker("Georgi", "Milkov", 1700, 7));

            var workersSelection =
                from worker in listOfWorkers
                orderby  worker.MoneyPerHour(worker) descending
                select worker;

            Console.WriteLine("Ordered Workers in by money per hour descending order.");
            Console.WriteLine();
            foreach (Worker worker in workersSelection)
            {
                Console.WriteLine("{0} {1} {2} leva", worker.FirstName, worker.LastName , (worker.MoneyPerHour(worker)).ToString());
            }
            Console.WriteLine();

            List<Human> listOfHumans = new List<Human>();
            listOfHumans.AddRange(listOfStudents);
            listOfHumans.AddRange(listOfWorkers);
            var humanSelection = listOfHumans
                .OrderBy(human => human.FirstName)
                .ThenBy(human => human.LastName);

            Console.WriteLine("Ordered humans by first name and then by last name. ");
                Console.WriteLine();
            foreach (Human human in listOfHumans) {
                Console.WriteLine("{0} {1}", human.FirstName, human.LastName);
            }
            
        }
       
    }
}
