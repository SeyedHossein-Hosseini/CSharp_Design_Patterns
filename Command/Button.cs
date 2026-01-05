using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Command
{
    internal class Button
    {
        private string _label;
        public string Label { get => _label; set => _label = value; }

        private IExportCommand command;

        public Button(IExportCommand command)
        {
            this.command = command;
        }

        public void Click()
        {
            command.Execute();
        }
    }
}
