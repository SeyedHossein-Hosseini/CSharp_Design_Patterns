using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Memento
{
    public class DocumentHistory
    {
        private readonly Stack<DocumentMemento> _undoStack = new();

        public void Save(DocumentOriginator documentOriginator)
        {
            _undoStack.Push(documentOriginator.CreateMemento());
        }

        public void Undo(DocumentOriginator documentOriginator)
        {
            if (_undoStack.Count == 0) return;
            
            var prevState = _undoStack.Pop();
            documentOriginator.Restore(prevState);
        }
    }
}
