using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation_test
{
    internal class Teacher : person
    {
        public string Subject { get; set; }
        public void DisplayTeacherInfo()
        {
            Console.WriteLine($"Name: {name}, Age: {Age}, School: {SchoolName}, Subject: {Subject}");
        }
    }
}
