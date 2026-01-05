using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Memento
{
    public class DocumentState
    {
        public string Content { get; set; }
        public int FontSize { get; set; }
        public string FontName { get; set; }
        public int FontWeight { get; set; } // 🔥 آماده توسعه آینده

        public DocumentState(
                    string content,
                    int fontSize,
                    string fontName,
                    int fontWeight = 400)
        {
            Content = content;
            FontSize = fontSize;
            FontName = fontName;
            FontWeight = fontWeight;
        }
    }
}
