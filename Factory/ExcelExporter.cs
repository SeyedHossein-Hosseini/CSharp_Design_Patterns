using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    [ExportFormatAttribute(Enums.excel)]
    internal class ExcelExporter : IReport
    {
        public void export(Report report)
        {
            Console.WriteLine($"Excel of {report.Title}");
        }
    }
}
