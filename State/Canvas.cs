using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.State
{
    public class Canvas
    {
        private Tool currentTool;

        public void MouseDown()
        {
            if (currentTool != null) 
                currentTool.MouseDown();
            return;
        }

        public void MouseUp()
        {
            if (currentTool != null)
                currentTool.MouseUp();
            return;
        }
        public void SetTool(Tool tool)
        {
            currentTool = tool;
        }
        public Tool GetTool()
        {
            return currentTool;
        }



    }
}
