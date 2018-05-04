using System;

namespace CSharp.Essential.Unit4
{
    public class TXTHandler:AbstractHandler    
   
    {
        private string fileName;

        public TXTHandler(string fileName)
        {
            this.fileName = fileName;
        }


        public override void Open()
        {
            Console.WriteLine("Openned file {0}",fileName);
//            throw new System.NotImplementedException();
        }

        public override void Save()
        {
            Console.WriteLine("Saved file {0}",fileName);
//            throw new System.NotImplementedException();
        }

        public override void Create()
        {
            Console.WriteLine("Created file {0}",fileName);
//            throw new System.NotImplementedException();
        }

        public override void Change()
        {
            Console.WriteLine("Changed file {0}",fileName);     
// throw new System.NotImplementedException();
        }
    }
}