using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    internal class Program
    {
        class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }

            public Person(string name, int age)
            {
                Name = name;
                Age = age;
            }

            public virtual void Introduce()
            {
                Console.WriteLine($"Hello, my name is {Name}, and I am {Age} years old.");
            }
        }

        class Student : Person
        {
            public int Grade { get; set; }

            public Student(string name, int age, int grade) : base(name, age)
            {
                Grade = grade;
            }

            public override void Introduce()
            {
                base.Introduce();
                Console.WriteLine($"I am a student in grade {Grade}.");
            }

            public void Study()
            {
                Console.WriteLine("I am studying for exams.");
            }
        }

        class Teacher : Person
        {
            public string Subject { get; set; }

            public Teacher(string name, int age, string subject) : base(name, age)
            {
                Subject = subject;
            }

            public override void Introduce()
            {
                base.Introduce();
                Console.WriteLine($"I am a teacher and I teach {Subject}.");
            }

            public void GradePapers()
            {
                Console.WriteLine("I am grading student papers.");
            }
        }

        static void Main()
        {
            Person person = new Person("John", 30);
            person.Introduce();

            Student student = new Student("Alice", 15, 10);
            student.Introduce();
            student.Study();

            Teacher teacher = new Teacher("Mr. Smith", 40, "Math");
            teacher.Introduce();
            teacher.GradePapers();

            Console.ReadKey();

        }
    }
}
