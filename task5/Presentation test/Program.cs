using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation_test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            person person = new person();
            person.name = "John Doe";
            person.Age = 30;
            //person.SchoolName = "ABC School";  // cant be accessed because it is protected
            //person._internalCode = 12345;  // cant be accessed because it is private

            student student1 = new student();

            student1.name = "Jane Smith";
            student1.Age = 20;
            student1.grade = 90;
            
            student1.DisplayStudentInfo();


            student student2 = new student();
            student2.name = "Bob Johnson";
            student2.Age = 22;
            student2.grade = 85;
            student2.DisplayInfo();
            //student1.SchoolName; = "XYZ School";  // can be accessed because it is protected

            Teacher teacher = new Teacher();
            
            teacher.name = "Mr. Smith";
            teacher.Age = 40;
            teacher.Subject = "Math";
            teacher.DisplayTeacherInfo();

            Console.WriteLine("Enter Report name");
            SchoolReport report = new SchoolReport(Console.ReadLine());
            report.DisplayReportTitle(report.Schoolreport);









        }
    }
}
