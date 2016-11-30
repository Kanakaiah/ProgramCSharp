using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anusha.Assignment2
{
    public class Student
    {
        public string studentId { get; set; }
        public string studentName { get; set; }
        public string University { get; set; }
        public string courseJoined { get; set; }
        public DateTime dateJoined { get; set; }

        public void DisplayStudentInfo()
        {
            Student student = new Student();
            student = GetStudentInfo();
            Console.WriteLine("Student Name {0}, Course {1}, Date of Joining {2}, University {3}", student.studentName, student.courseJoined, student.dateJoined, student.University);
        }
        public Student GetStudentInfo()
        {
            Student student = new Student();
            Console.WriteLine("Enter Name");
            student.studentName = Console.ReadLine();
            Console.WriteLine("Enter Course");
            student.courseJoined = Console.ReadLine();
            Console.WriteLine("Enter University");
            student.University = Console.ReadLine();
           // DateTime dateJoined = new DateTime();
            Console.WriteLine("Enter the date of joining");
            student.dateJoined = Convert.ToDateTime(Console.ReadLine());
            return student;


        }
    }
}
