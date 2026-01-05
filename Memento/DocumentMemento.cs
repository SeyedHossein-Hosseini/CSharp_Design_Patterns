using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Memento
{
    public class DocumentMemento
    {
        public DocumentStateBuilder State { get; set; }

        public DocumentMemento(DocumentStateBuilder state)
        {
            State = state;
        }
    }
}
