using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Student1
{
    class Student
    {
        double totalpoints=0;
        double countofclasses=0;
        double worth;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<string> CourseNames { get; set; }
        public List<string> CourseGrades { get; set; }

        public Student()
        {
            FirstName = "";
            LastName = "";
            CourseNames = CourseNames;
            CourseGrades = CourseGrades;
        }
        public Student(string first, string last)
        {
            FirstName = first;
            LastName = last;
        }
        public double CalculateGPA()
        {
            foreach (var coursegrade in CourseGrades)
            {
                totalpoints = totalpoints + worth;
                countofclasses += countofclasses;
                if (coursegrade=="A")
                {
                    worth = 4;
                }
                else if (coursegrade=="B")
                {
                    worth = 3;
                }
                else if (coursegrade=="C")
                {
                    worth = 2;
                }
                else if (coursegrade=="D")
                {
                    worth = 1;
                }
                else
                {
                    worth = 0;
                }

            }
            return totalpoints / countofclasses;
        }
    }
}
