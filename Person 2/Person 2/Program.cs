using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person_2
{
    public class Person
    {
        public string Name;
        public int Age;
        public string Gender;

        public Person(string name, int age, string gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }

        public Person()
        { Name = "Jane Doe"; Age = 30; Gender = "female"; }

        public virtual void GetGoal()
        {
            Console.WriteLine("My goal is: Live for the moment!");
        }

        public virtual void Introduce()
        {
            Console.WriteLine($"Hi, I'm {Name}, a {Age} year old {Gender}");
        }
    }

    public class Student : Person
    {
        public string previousOrganization;
        public int skippedDays;
        public Student(string name, int age, string gender, string previosorganization) : base(name, age, gender)
        {
            previousOrganization = previosorganization;
            skippedDays = 0;
        }
        public Student() : base()
        {
            previousOrganization = "The School of Life";
            skippedDays = 0;
        }
        public override void GetGoal()
        {
            base.GetGoal();
            Console.WriteLine("Be a junior software developer");
        }

        public override void Introduce()
        {
            base.Introduce();
            Console.WriteLine($"Hi, I'm {Name},a {Age} years old from {previousOrganization} " +
                $"who skipped {skippedDays} days from the course already");
        }

        public int SkipDays(int numberOfDays)
        {
            numberOfDays = 0;
            return skippedDays += numberOfDays;
        }


    }

    public class Mentor : Person
    {
        public string level;
        public Mentor(string name, int age, string gender, string level) : base(name, age, gender)
        {
            this.level = level;
        }
        public Mentor() : base()
        {
            level = "intermediate";
        }

        public override void GetGoal()
        {
            base.GetGoal();
            Console.WriteLine("Educate brilliant junior software developers.");
        }

        public override void Introduce()
        {
            base.Introduce();
            Console.WriteLine($"Hi, I'm {Name},a {Age} years old {level} mentor");
        }

    }

    public class Sponsor : Person
    {
        public string company;
        public int hiredStudents;
        public Sponsor(string name, int age, string gender, string company) : base(name, age, gender)
        {
            hiredStudents = 0;
        }

        public Sponsor() : base()
        {
            company = "Google";
            hiredStudents = 0;
        }

        public int Hire() { return hiredStudents++; }
        public override void GetGoal()
        {
            base.GetGoal();
            Console.WriteLine("Hire brilliant junior software developers.");
        }

        public override void Introduce()
        {
            base.Introduce();
            Console.WriteLine($"Hi, I'm {Name},a {Age} years old who represents {company} " +
                $"and hired {hiredStudents} students so far");
        }
    }

    public class Cohort
    {
        public string name;
        public List<Student> Students;
        public List<Mentor> Mentors;

        public Cohort(string cohortName)
        {
            name = cohortName;
            Students = new List<Student>(); // Initialize the Students list
            Mentors = new List<Mentor>();
        }

        public void AddStudent(Student student)
        {
            Students.Add(student);
        }

        public void AddMentor(Mentor mentor)
        {
            Mentors.Add(mentor);
        }


        public void info()
        {
            Console.WriteLine($"Cohort: {name}");
            Console.WriteLine("Students:");
            foreach (var student in Students)
            {
                Console.WriteLine($"  {student}");
            }
            Console.WriteLine("Mentors:");
            foreach (var mentor in Mentors)
            {
                Console.WriteLine($"  {mentor}");
            }
        }
    }
    internal class Program
    {
        enum Gender
        {
            Male,
            Female,
            Other
        }
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            Person mark = new Person("Mark", 46, Gender.Male.ToString());
            people.Add(mark);

            Person jane = new Person();
            people.Add(jane);

            Student john = new Student("John Doe", 20, Gender.Male.ToString(), "BME");
            people.Add(john);

            Student student = new Student();
            people.Add(student);

            Mentor gandhi = new Mentor("Gandhi", 148, Gender.Male.ToString(), "senior");
            people.Add(gandhi);

            Mentor mentor = new Mentor();
            people.Add(mentor);

            Sponsor elon = new Sponsor("Elon Musk", 46, Gender.Male.ToString(), "SpaceX");
            people.Add(elon);

            Sponsor sponsor = new Sponsor();
            people.Add(sponsor);

            student.SkipDays(3);

            for (int i = 0; i < 6; i++)
            {
                elon.Hire();
            }

            for (int i = 0; i < 4; i++)
            {
                sponsor.Hire();
            }

            foreach (Person person in people)
            {
                person.Introduce();
                person.GetGoal();
            }

            Cohort awesome = new Cohort("AWESOME");
            awesome.AddStudent(student);
            awesome.AddStudent(john);
            awesome.AddMentor(mentor);
            awesome.AddMentor(gandhi);
            awesome.info();

            Console.ReadKey();
        }
    }
}
