using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teacher_Student
{
    class Student
    {
        public void Learn() { Console.WriteLine("The student is currently learning."); }

        public void Question(Teacher teacher) { teacher.giveAnswer(); }


    }


    class Teacher
    {
        public void giveAnswer() { Console.WriteLine("The teacher answer a question."); }

        public void Teach(Student student) { student.Learn(); }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            Teacher teacher = new Teacher();
            student.Question(teacher);
            teacher.Teach(student);

            Console.ReadKey();

        }
    }
}
