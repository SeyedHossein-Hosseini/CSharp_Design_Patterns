using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    [ExportFormatAttribute(Enums.pdf)]
    public class PdfExporter : IReport
    {
        public void export(Report report)
        {
            Console.WriteLine($"PDF of {report.Title}");
        }
    }
}
