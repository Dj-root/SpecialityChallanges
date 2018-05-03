using System;

namespace CSharp.Essential.Unit3
{
    public class ExpertDocumentWorker : ProDocumentWorker
    {
        public override void SaveDocument()
        {
            Console.WriteLine("Document saved in newer format");
        }
    }
}