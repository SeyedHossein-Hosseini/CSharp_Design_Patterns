using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    internal class ReportExporterFactory
    {
        // good practice
        private readonly Dictionary<Enums, Type> _exporters;

        public ReportExporterFactory()
        {
            _exporters = Assembly.GetExecutingAssembly()
                .GetTypes()
                .Where(t =>
                    typeof(IReport).IsAssignableFrom(t) &&
                    !t.IsInterface &&
                    !t.IsAbstract)
                .Select(t => new
                {
                    Type = t,
                    Attribute = t.GetCustomAttribute<ExportFormatAttribute>()
                })
                .Where(x => x.Attribute != null)
                .ToDictionary(
                    x => x.Attribute!.Types,
                    x => x.Type
                );
        }

        internal IReport Create(Enums format)
        {

            if (!_exporters.TryGetValue(format, out var type))
                throw new NotSupportedException($"Export format '{format}' not supported");

            return (IReport)Activator.CreateInstance(type)!;
        }



        // bad practice
        public void Export(Enums type, string report)
        {
            switch (type)
            {
                case Enums.pdf:
                    Console.WriteLine($"PDF of {report}");
                    break;

                case Enums.excel:
                    Console.WriteLine($"EXCEL of {report}");
                    break;

                case Enums.csv:
                    Console.WriteLine($"CSV of {report}");
                    break;

                default:
                    throw new ArgumentOutOfRangeException(nameof(type), type, null);
            }
        }
    }
}
