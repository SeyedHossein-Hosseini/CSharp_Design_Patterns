using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.State
{
    public static class StateMain
    {
        public static void Main()
        {
            var canvas = new Canvas();
            canvas.SetTool(new Brush());

            canvas.MouseUp();
            canvas.MouseDown();


            var canvas2 = new Canvas();
            canvas2.SetTool(new Selection());

            canvas2.MouseUp();
            canvas2.MouseDown();


        }

    }
}
