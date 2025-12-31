using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    public static class MainFactory
    {
        public static void Main()
        {
            //var exportReport = new ReportExporterFactory();
            //exportReport.Export(Enums.csv, "hello world !!");

            var report = new Report();
            report.Title = "navbar";
            report.Description = "this is a test";

            var reportExporterFactory = new ReportExporterFactory();
            var factory = reportExporterFactory.Create(Enums.excel);
            factory.export(report);
            


        }
    }
}
