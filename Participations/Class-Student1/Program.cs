using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Student1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stu1 = new Student("Shawn", "Ross");
            stu1.CourseNames.Add("MIS3013");
            stu1.CourseNames.Add("MIS3033");
            stu1.CourseGrades.Add("A");
            stu1.CourseGrades.Add("B");


            Student stu2 = new Student("Jim", "Johnson");
            stu1.CourseNames.Add("MIS3013");
            stu1.CourseNames.Add("MIS3033");
            stu1.CourseGrades.Add("B");
            stu1.CourseGrades.Add("C");

            Console.WriteLine("Student " + stu1.FirstName + " " + stu1.LastName + "'s GPA is " + stu1.CalculateGPA());
            Console.WriteLine("Student " + stu2.FirstName + " " + stu2.LastName + "'s GPA is " + stu2.CalculateGPA());


            Console.ReadKey();
        }
    }
}
