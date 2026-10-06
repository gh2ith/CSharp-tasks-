using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "John Doe";
            int age = 30;
            double grade = 3.5;
            double average = (grade + age) / 2;
            string gender = "Male";
            bool isActive = true;

            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Grade: " + grade);
            Console.WriteLine("Average: " + average);
            Console.WriteLine("Gender: " + gender);
            Console.WriteLine("Is Active: " + isActive);

            string[] students = { "Alice", "Bob", "Charlie", "khalid" };
            
            Console.WriteLine("\n\nStudent:" + students[0]);
            Console.WriteLine("Student:" + students[1]);
            Console.WriteLine("Student:" + students[2]);
            Console.WriteLine("Student:" + students[3]);

             
            students[2] = "David";

            Console.WriteLine("\n\nUpdated\n\nStudent:" + students[0]);
            Console.WriteLine("Student:" + students[1]);
            Console.WriteLine("Student:" + students[2]);
            Console.WriteLine("Student:" + students[3]);
            Console.WriteLine(students.Length);





        }
    }
}
