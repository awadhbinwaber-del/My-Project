using System;

namespace UniversityMembers
{
    public class Person
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public Person(string name, string email)
        {
            Name = name;
            Email = email;
            Console.WriteLine("Person Constructor Executed.");
        }

        public void DisplayBasicInfo()
        {
            Console.WriteLine($"Name: {Name}, Email: {Email}");
        }
    }

    public class Student : Person
    {
        public string StudentId { get; set; }
        public double GPA { get; set; }

        public Student(string name, string email, string studentId, double gpa)
            : base(name, email)
        {
            StudentId = studentId;
            GPA = gpa;
            Console.WriteLine("Student Constructor Executed.");
        }

        public void DisplayStudentInfo()
        {
            DisplayBasicInfo();
            Console.WriteLine($"Student ID: {StudentId}, GPA: {GPA}");
        }
    }

    public class Employee : Person
    {
        public string EmployeeId { get; set; }
        public double Salary { get; set; }

        public Employee(string name, string email, string employeeId, double salary)
            : base(name, email)
        {
            EmployeeId = employeeId;
            Salary = salary;
            Console.WriteLine("Employee Constructor Executed.");
        }
    }

    public class Teacher : Employee
    {
        public string CourseName { get; set; }

        public Teacher(string name, string email, string employeeId, double salary, string courseName)
            : base(name, email, employeeId, salary)
        {
            CourseName = courseName;
            Console.WriteLine("Teacher Constructor Executed.");
        }

        public void Teach()
        {
            Console.WriteLine($"{Name} is teaching the course: {CourseName}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            Student student = new Student("Ali", "ali@uni.com", "S1001", 3.8);

           
            Teacher teacher = new Teacher("Dr. Ahmed", "ahmed@uni.com", "E500", 1200, "C# Programming");

           
            Console.WriteLine("Student Info:");
            student.DisplayStudentInfo();

            Console.WriteLine("\nTeacher Info:");
            teacher.DisplayBasicInfo();
            teacher.Teach();
        }
    }
}
