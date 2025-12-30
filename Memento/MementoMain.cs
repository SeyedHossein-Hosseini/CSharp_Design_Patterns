using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Memento
{
    public static class MementoMain
    {
        public static void Main()
        {
            var document = new DocumentOriginator(
                content: "Hello",
                fontName: "Arial",
                fontSize: 12
            );

            var history = new DocumentHistory();

            history.Save(document);
            document.SetContent("Hello World");

            history.Save(document);
            document.SetFontSize(16);

            history.Save(document);
            document.SetFontName("Times New Roman");

            Console.WriteLine(document);
            // Content='Hello World', Font='Times New Roman', Size=16

            history.Undo(document);
            Console.WriteLine(document);
            // Content='Hello World', Font='Arial', Size=16

            history.Undo(document);
            Console.WriteLine(document);
            // Content='Hello World', Font='Arial', Size=12

            history.Undo(document);
            Console.WriteLine(document);
            // Content='Hello', Font='Arial', Size=12

        }
    }
}
