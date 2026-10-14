using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Alice", 20, 85.5);
            Student student2 = new Student("Bob", 22, 90.0);
            Student student3 = new Student("Charlie", 19, 78.0);

            student1.displayInfo();
            student2.displayInfo();
            student3.displayInfo();




        }
    }
}
