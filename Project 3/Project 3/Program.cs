using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Project_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int number = random.Next(50, 56);
            Console.WriteLine("Guess the number between 50 and 55.");
            int gueessedNumber = int.Parse(Console.ReadLine());
            int counter = 1;
            int points = 0;
            while (gueessedNumber != number)
            {
                if (gueessedNumber < number)
                {
                    Console.WriteLine("The number is higher than your guess. Try again.");
                    gueessedNumber = int.Parse(Console.ReadLine());
                    counter++;
                }
                else
                {
                    Console.WriteLine("The number is lower than your guess. Try again.");
                    gueessedNumber = int.Parse(Console.ReadLine());
                    counter++;
                }
            }
            switch (counter)
            {
                case 1:
                    points = points + 10;
                    break;

                case 2:
                    points = points + 7;

                    break;

                case 3:
                    points = points + 5;

                    break;

                default:
                    points = 0;
                    break;
            }
            Console.WriteLine("Congratulations! You guessed the number.");
            Console.WriteLine($"\nIt took you {counter} tries. you scored {points} points.");


            string[] students = { "John", "Jane", "Bob", "Alice", "Tom" };

            foreach (string student in students)
            {
                Console.WriteLine(student);
            }
            int[] grade = { 85, 90, 78, 92, 88 };
            Console.WriteLine("g");
            foreach (int grades in grade)
            {
                Console.WriteLine($"Grade: {grades}");
            }

            Console.WriteLine("\nEnter Student name you wanna search for:");
            string name = Console.ReadLine();
            while (true)
            {
                if (students.Contains(name))
                {
                    Console.WriteLine($"Student {name} found.");
                    break;
                }
                else
                {
                    Console.WriteLine($"Student {name} not found. Please enter a valid name:");
                    name = Console.ReadLine();
                }
            }
        }
    }
}
