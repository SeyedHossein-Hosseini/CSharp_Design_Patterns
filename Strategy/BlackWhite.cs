using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy
{
    public class BlackWhite : IFilter
    {

        public void filter(string filename)
        {
            Console.WriteLine("Black White filter");
        }
    }
}
