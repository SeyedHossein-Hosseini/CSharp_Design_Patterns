using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    public sealed class ExportFormatAttribute: Attribute
    {
        public Enums Types { get; set; }

        public ExportFormatAttribute(Enums types)
        {
            Types = types;
        }
    }
}
