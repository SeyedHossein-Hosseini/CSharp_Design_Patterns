using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Memento
{
    public class DocumentOriginator
    {
        private DocumentStateBuilder _state;

        public DocumentOriginator(DocumentStateBuilder state)
        {
            _state = state;
        }

        //public void Update(Action<DocumentState> update)
        //{
        //    var builder = new DocumentStateBuilder(_state);
        //    update(builder);
        //    _state = builder.Build();
        //}

        public DocumentMemento CreateMemento()
        {
            return new DocumentMemento(_state);
        }

        public void Restore(DocumentMemento memento)
        {
            _state = memento.State;
        }

        public override string ToString()
        {
            var properties = _state
                .GetType()
                .GetProperties();

            return string.Join(", ",
                properties.Select(p => $"{p.Name}={p.GetValue(_state)}"));
        }
    }
}
