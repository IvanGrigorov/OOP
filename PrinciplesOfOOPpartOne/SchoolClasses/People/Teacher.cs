/* We are given a school. In the school there are classes of students. Each class has a set of teachers. 
   Each teacher teaches, a set of disciplines. Students have a name and unique class number. 
   Classes have unique text identifier. Teachers have a name. Disciplines have a name, number of lectures and number of exercises.
   Both teachers and students are people. Students, classes, teachers and disciplines could have optional comments (free text block).
   Your task is to identify the classes (in terms of OOP) and their attributes and operations, 
   encapsulate their fields, define the class hierarchy and create a class diagram with Visual Studio.*/



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClasses
{
    class Teacher : People
    {
        #region Fields

        private List<Disciplines> disciplinesList;

        #endregion

        #region Properties
        public List<Disciplines> ListOfDiscipline 
        {
            get 
            {
                return new List<Disciplines>(this.disciplinesList);
            }
        }

        #endregion

        #region Constructor

        public Teacher(string fName, string lName) 
            : base(fName, lName)
        {
            this.disciplinesList = new List<Disciplines>();
        }

        #endregion
    }
}
