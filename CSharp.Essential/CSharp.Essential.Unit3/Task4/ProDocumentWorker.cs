using System;

namespace CSharp.Essential.Unit3
{
    public class ProDocumentWorker : DocumentWorker
    {
        public override void EditDocument()
        {
            Console.WriteLine("Document edited");
        }

        public override void SaveDocument()
        {
            Console.WriteLine("Document saved in old format, saving in other formats allowed in Expert edition");
        }
    }
}