using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy
{
    public class ImageStorage
    {

        public void store(string filename, ICompressor compressor, IFilter filter)
        {
            compressor.compress(filename);
            filter.filter(filename);
        }


         
    }
}
