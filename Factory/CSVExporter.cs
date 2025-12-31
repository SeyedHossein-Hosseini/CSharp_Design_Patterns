using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    [ExportFormatAttribute(Enums.csv)]
    public class CSVExporter : IReport
    {
        public void export(Report report)
        {
            Console.WriteLine($"CSV of {report.Title}");
        }
    }
}
