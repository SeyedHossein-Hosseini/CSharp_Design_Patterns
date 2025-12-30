using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy
{
    public static class MainStrategy
    {
        public static void Main()
        {
            var imageStorage = new ImageStorage();
            imageStorage.store("a", new PngCompressor(), new BlackWhite());
          

        }
    }
}
