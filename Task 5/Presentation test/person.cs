using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation_test
{
     internal class person
    {
        public string name;

        public int Age { get; set; }

        protected string SchoolName { get; set; }

        private int _internalCode;


        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {name}, Age: {Age}, School: {SchoolName}");


        }
    }
}
