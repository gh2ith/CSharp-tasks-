using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Student
    {
        public string name;
        public int age;
        public double gpa;

        public Student(string name, int age, double gpa)
        {
            this.name = name;
            this.age = age;
            this.gpa = gpa;
        }


        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {name}, Age: {age}, GPA: {gpa}");
        }

    }
}
