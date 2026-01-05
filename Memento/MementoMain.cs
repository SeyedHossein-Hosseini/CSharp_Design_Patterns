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
            var history = new DocumentHistory();

            var documentState_ = new DocumentState(content: "Hello", 12, "Bnazanin", 600);
            var documentState = new DocumentStateBuilder(documentState_);
            var document = new DocumentOriginator(documentState);

            history.Save(document);
            Console.WriteLine(document);


            var documentState_2 = new DocumentState(content: "Goodbye", 4, "BYekan", 400);
            var documentState2 = new DocumentStateBuilder(documentState_2);
            var document2 = new DocumentOriginator(documentState2);

            history.Save(document2);
            Console.WriteLine(document2);


            history.Undo(document);
            Console.WriteLine(document);

            history.Undo(document);
            Console.WriteLine(document);

        }
    }
}
