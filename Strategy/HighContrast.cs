using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy
{
    public class HighContrast : IFilter
    {

        public void filter(string filename)
        {
            Console.WriteLine("High constrast filter");
        }
    }
}
