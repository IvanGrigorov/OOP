using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAndWorkers
{
    class Student : Human
    {
        protected int grade;

        #region Properties
        public int Grade 
        {
            get
            {
                return this.grade;
            }
            set
            {
                if (value < 2 || value > 6)
                {
                    throw new ArgumentException("There can't be a grade lower then two and grade higher then six");
                }
                this.grade = value;
            }
        }
        #endregion

        #region Constructor
        public Student(string fName, string lName, int grade)
            : base(fName, lName)
        {
            this.Grade = grade;
        }
        #endregion
    }
}
