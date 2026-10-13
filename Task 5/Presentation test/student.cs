using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation_test
{
    internal class student : person

    {
        public int grade { get; set; }

        public int StudentId { get; set; }


        public void DisplayStudentInfo()
        {
            Console.WriteLine($"Name: {name}, Age: {Age}, School: {SchoolName}, Grade: {grade}, Student ID: {StudentId}");
        }
    }
}
