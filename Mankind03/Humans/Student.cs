using System;
using System.Collections.Generic;
using System.Text;

namespace Mankind03.Humans
{
    public class Student : Human
    {
        private string facultyNumber;

        public Student(string firstName, string lastName, string facultyNumber) 
            : base(firstName, lastName)
        {
            FacultyNumber = facultyNumber;
        }

        public string FacultyNumber { get => facultyNumber; set => facultyNumber = value; }
    }
}
