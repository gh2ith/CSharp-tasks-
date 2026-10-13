using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation_test
{
    sealed class SchoolReport
    {
        public string Schoolreport { get; set; }

        public SchoolReport(string schoolReport)
        {
            Schoolreport = schoolReport;
        }

        public void DisplayReportTitle(string schoolReport)
        {
            Console.WriteLine($"School Report: {schoolReport}");
        }
    }
}
