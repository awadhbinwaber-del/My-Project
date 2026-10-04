using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Member
{


    // 1. الفئة الأساسية (Base Class)
    class Person
    {
        public string Name { get; set; }

        public Person(string name)
        {
            Name = name;
        }

        // دالة افتراضية للسماح بإعادة كتابتها في الفئات الفرعية
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}");
        }
    }

    // 2. فئة الطالب (وراثة من Person)
    class Student : Person
    {
        public string StudentId { get; set; }

        public Student(string name, string studentId) : base(name)
        {
            StudentId = studentId;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Student Name: {Name}, Student ID: {StudentId}");
        }
    }

    // 3. فئة الموظف (وراثة من Person)
    class Employee : Person
    {
        public double Salary { get; set; }

        public Employee(string name, double salary) : base(name)
        {
            Salary = salary;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Employee Name: {Name}, Salary: {Salary}");
        }
    }

    // 4. فئة المعلم (وراثة من Person)
    class Teacher : Person
    {
        public string CourseName { get; set; }

        public Teacher(string name, string courseName) : base(name)
        {
            CourseName = courseName;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Teacher Name: {Name}, Course: {CourseName}");
        }




        internal class Program
        {
            static void ProcessPerson( Person p)
            {
                p.DisplayInfo();
            }

            static void Main(string[] args)
            {
               
            List<Person> universityMembers = new List<Person>
            {
                new Student("Ahmed", "S1001"),
                new Employee("Mohammed", 1500.00),
                new Teacher("Dr. Ali", "Computer Science")
            };

                Console.WriteLine("=== University Members Details ===\n");

                // استخدام حلقة foreach واحدة لاستدعاء DisplayInfo وطباعة GetType()
                foreach (var member in universityMembers)
                {
                    // طباعة نوع الكائن أثناء وقت التشغيل (Runtime Type)
                    Console.WriteLine($"[Runtime Type]: {member.GetType()}");

                    // استدعاء دالة العرض
                    member.DisplayInfo();

                    Console.WriteLine("-----------------------------------");
                }

                // اختبار الطريقة التي تقبل كائن Person
                Console.WriteLine("\n=== Testing Method that accepts Person ===");
                Person sample = new Student("Fatima", "S1002");
               ProcessPerson( sample );
            }
        }



    }
}
    


