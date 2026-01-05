using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Memento
{
    public class DocumentStateBuilder
    {
        private DocumentStateBuilder state;

        public string Content { get; set; }
        public int FontSize { get; set; }
        public string FontName { get; set; }
        public int FontWeight { get; set; } // 🔥 آماده توسعه آینده

        public DocumentStateBuilder(DocumentState state)
        {
            Content = state.Content;
            FontSize = state.FontSize;
            FontName = state.FontName;
            FontWeight = state.FontWeight;
        }

        public DocumentStateBuilder(DocumentStateBuilder state)
        {
            this.state = state;
        }

        public DocumentState Build()
        {
            return new DocumentState(
                Content,
                FontSize,
                FontName,
                FontWeight
            );
        }
    }
}
