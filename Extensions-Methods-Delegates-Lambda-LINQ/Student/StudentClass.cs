/* Creating this class as a ressource for other tasks*/
/* Create a class Student with properties FirstName, LastName, FN, Tel, Email, Marks (a List), GroupNumber.*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    public class StudentClass
    {
        #region Fields

        private List<int> marks = new List<int>();

        #endregion 

        #region Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ulong FN { get; set; } // Faculty number 
        public ulong Tel { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public int GroupNumber { get; set; }
        public int Age { get; set; }

        public List<int> Marks
        {
            get { return this.marks; }
        }

        #endregion

        #region Constructors

        public StudentClass(string fName, string lName, ulong fn, ulong tel, string email, int groupNumber, int age)
        {
            this.FirstName = fName;
            this.LastName = lName;
            this.FN = fn;
            this.Tel = tel;
            this.Email = email;
            this.GroupNumber = groupNumber;
            this.Age = age;
            this.marks = new List<int>();
        }
        public StudentClass(string fName, string lName, ulong fn, string tel, string email, int groupNumber, int age)
        {
            this.FirstName = fName;
            this.LastName = lName;
            this.FN = fn;
            this.Telephone = tel;
            this.Email = email;
            this.GroupNumber = groupNumber;
            this.Age = age;
            this.marks = new List<int>();
        }

        #endregion

        static void Main(string[] args)
        {
        }
    }
}
