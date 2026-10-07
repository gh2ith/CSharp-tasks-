using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your Grade: ");
            double grade = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter your Average: ");
            double average   = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter your gender: ");
            string gender = Console.ReadLine();
            Console.WriteLine("Your information is: ");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Grade: " + grade);
            Console.WriteLine("Average: " + average);
            Console.WriteLine("Gender: " + gender);

            Console.WriteLine(name.ToUpper());
            Console.WriteLine(name.ToLower());
            Console.WriteLine(name[0]);

            Console.WriteLine("original average: " + average);
            Console.WriteLine("Average after adding grades: " + (average + 5));

        }
    }
}
