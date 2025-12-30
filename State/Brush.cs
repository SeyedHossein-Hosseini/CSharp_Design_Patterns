using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.State
{
    public class Brush : Tool
    {
        public void MouseDown()
        {
            Console.WriteLine("Brush Mouse Down");
        }

        public void MouseUp()
        {
            Console.WriteLine("Brush Mouse Up");
        }
    }
}
