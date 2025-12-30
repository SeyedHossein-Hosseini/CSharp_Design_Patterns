using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.State
{
    public class Selection : Tool
    {
        public void MouseDown()
        {
            Console.WriteLine("Selection Mouse Down");
        }

        public void MouseUp()
        {
            Console.WriteLine("Selection Mouse Up");
        }
    }
}
