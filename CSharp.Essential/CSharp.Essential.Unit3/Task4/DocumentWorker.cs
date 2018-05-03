using System;

namespace CSharp.Essential.Unit3
{
    public class DocumentWorker
    {
        public virtual void OpenDocument()
        {
            Console.WriteLine("Document Opened");
        }

        public virtual void EditDocument()
        {
            Console.WriteLine("Editing allowed in Pro Edition");
        }

        public virtual void SaveDocument()
        {
            Console.WriteLine("Saving allowed in Pro Edition");
        }
    }
}

//