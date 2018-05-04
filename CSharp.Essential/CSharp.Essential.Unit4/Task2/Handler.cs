using System;

namespace CSharp.Essential.Unit4
{
    public class Handler
    {
        private string sourceName;

        public Handler(string sourceName)
        {
            this.sourceName = sourceName;
        }

        public AbstractHandler Handle()
        {
            AbstractHandler type;
            string ext =  sourceName.Substring((sourceName.IndexOf('.') + 1));
            
//            Console.WriteLine("Pos of dot: {0}", sourceName.IndexOf('.'));
//            Console.WriteLine("Ext is: {0}", sourceName.Substring((sourceName.IndexOf('.')+1)));

//            ext = sourceName.Substring((sourceName.IndexOf('.') + 1));

            switch (ext)
            {
                    case "doc":
                        type = new DOCHandler(sourceName);
                        Console.WriteLine("Created instance of DOCHandler");
                        break;
                    case "txt":
                        type = new TXTHandler(sourceName);
                        Console.WriteLine("Created instance of TXTHandler");
                        break;
                    case "xml":
                        type = new XMLHandler(sourceName);
                        Console.WriteLine("Created instance of XMLHandler");
                        break;
                    default:
                        Console.WriteLine("Incorrect source type!");
                        return null;
            }

            return type;
        }
    }
}