using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Memento
{
    public class DocumentOriginator
    {
        private string Content;
        private int FontSize;
        private string FontName;

        public DocumentOriginator(string content, int fontSize, string fontName)
        {
            this.Content = content;
            this.FontSize = fontSize;
            this.FontName = fontName;
        }

        public void SetContent(string content)
        {
            this.Content = content.Trim();
        }

        public void SetFontSize(int fontSize)
        {
            this.FontSize= fontSize;
        }

        public void SetFontName(string fontName)
        {
            this.FontName = fontName;
        }

        public string GetContent()
        {
            return this.Content;
        }

        public int GetFontSize()
        {
            return this.FontSize;
        }

        public void GetFontName(string fontName)
        {
            this.FontName = fontName;
        }




        public DocumentMemento CreateMemento()
        {
            return new DocumentMemento(Content, FontSize, FontName);
        }

        public void Restore(DocumentMemento memento)
        {
            Content = memento.Content;
            FontSize = memento.FontSize;
            FontName = memento.FontName;
        }

        public override string ToString()
        {
            return $"Content={Content}, FontSize={FontSize}, FontName={FontSize}";
        }
    }
}
