using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Student
    {
        public string name;
        public int age;

        public double grade;

        public Student(string name, int age, double grade)
        {
            this.name = name;
            this.age = age;
            this.grade = grade;
        }
        public void displayInfo()
        {
            Console.WriteLine($"Name: {name}, Age: {age}, Grade: {grade}\n");
        }


    }
}
