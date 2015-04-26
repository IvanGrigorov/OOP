namespace StudentsAndPersons
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    class Student : ICloneable, IComparable
    {

        #region Costructors
        // We need the empty constructor for the cloning
        public Student()
        {
                
        }
        public Student(string fName, string mName, string lName, long ssn, string pAddress, string telephone,
            string email, short course, SpecialtiesEnumeration specialty, UniversitiesEnumeration university, 
            FacultiesEnumeration faculty)
        {
            this.FirstName = fName;
            this.MiddleName = mName;
            this.LastName = lName;
            this.SSN = ssn;
            this.PersonalAddress = pAddress;
            this.Telephone = telephone;
            this.Email = email;
            this.Course = course;
            this.Speciality = Speciality;
            this.University = university;
            this.Faculty = faculty;
        }

        #endregion

        #region Properties

        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public long SSN { get; set; }
        public string PersonalAddress { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public short Course { get; set; }
        public SpecialtiesEnumeration  Speciality { get; set; }
        public UniversitiesEnumeration University { get; set; }
        public FacultiesEnumeration Faculty { get; set; }

        #endregion

        #region Methods

        public object Clone()
        {
            // We don't have any collections so 
            // we can use the method MemberwiseClone directly 
            // return this.MemberwiseClone();
            // but our task is to create deep coping so
            var copiedStudent = new Student();
            copiedStudent.Course = this.Course;
            copiedStudent.Email = this.Email;
            copiedStudent.Faculty = this.Faculty;
            copiedStudent.FirstName = this.FirstName;
            copiedStudent.LastName = this.LastName;
            copiedStudent.MiddleName = this.MiddleName;
            copiedStudent.PersonalAddress = this.PersonalAddress;
            copiedStudent.Speciality = this.Speciality;
            copiedStudent.SSN = this.SSN;
            copiedStudent.Telephone = this.Telephone;
            copiedStudent.University = this.University;
            return copiedStudent;
        }

        public override bool Equals(object obj)
        {
            var student = obj as Student;
            if (this.Course == student.Course &&
                this.Email == student.Email &&
                this.Faculty == student.Faculty &&
                this.FirstName == student.FirstName &&
                this.LastName == student.LastName &&
                this.MiddleName == student.MiddleName &&
                this.PersonalAddress == student.PersonalAddress &&
                this.Speciality == student.Speciality &&
                this.SSN == student.SSN &&
                this.Telephone == student.Telephone &&
                this.University == student.University)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override int GetHashCode()
        {
            // This version of GetHashCode is enaugh unique
            // because SSN is also unique
            int hashCode = (int)(this.SSN.ToString()[0] - '0') ^ (int)this.Course;
            for (int i = 1; i < this.SSN.ToString().Length; i++)
            {
                for (int j = 0; j < this.Course.ToString().Length; j++)
                {
                    hashCode = hashCode ^ ((int)(this.SSN.ToString()[i] - '0') ^ (int)(this.Course.ToString()[j] - '0'));
                }
            }
            return hashCode;
        }
        public override string ToString()
        {
            // I won't print the SSN because it is confidential
            StringBuilder studentInfo = new StringBuilder();
            studentInfo.Append("This is student ");
            studentInfo.Append(this.FirstName + " ");
            studentInfo.Append(this.MiddleName + " ");
            studentInfo.Append(this.LastName + "\n");
            studentInfo.Append("He lives in ");
            studentInfo.Append(this.PersonalAddress + "\n");
            studentInfo.Append("His e-mail and telephone are: " + this.Email + ", "  + this.Telephone.ToString() + "\n");
            studentInfo.Append("He studies in " + this.University.ToString() + "\n");
            studentInfo.Append("His faculty is " + this.Faculty.ToString());
            studentInfo.Append(" with specialty " + this.Speciality.ToString());
            return studentInfo.ToString();
        }
        public int CompareTo(object student)
        {
            var comparingStudent = (Student)student;
            if (this.FirstName == comparingStudent.FirstName)
            {
                return this.SSN.CompareTo(comparingStudent.SSN);
            }
            return this.FirstName.CompareTo(comparingStudent.FirstName);
        }

        #endregion

        #region Operators 

        public static bool operator ==(Student firstStudent, Student secondStudent) 
        {
            return firstStudent.Equals(secondStudent);
        }
        public static bool operator !=(Student firstStudent, Student secondStudent)
        {
            return !(firstStudent.Equals(secondStudent));
        }

        #endregion
    }
}
