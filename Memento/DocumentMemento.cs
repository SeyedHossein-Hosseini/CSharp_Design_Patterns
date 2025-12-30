using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Memento
{
    public class DocumentMemento
    {
        public string Content;
        public int FontSize;
        public string FontName;

        public DocumentMemento(string content, int fontSize, string fontName)
        {
            this.Content = content;
            this.FontSize = fontSize;
            this.FontName = fontName;
        }
    }
}
