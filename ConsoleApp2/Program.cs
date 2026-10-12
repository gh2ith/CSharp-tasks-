using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student ghaith = new Student("Ghaith", 20, 3.5);
            Student ali = new Student("Ali", 22, 3.7);
            Student issa = new Student("Issa", 23, 3.9);
            ghaith.DisplayInfo();
            ali.DisplayInfo();
            issa.DisplayInfo();


        }
    }
}
