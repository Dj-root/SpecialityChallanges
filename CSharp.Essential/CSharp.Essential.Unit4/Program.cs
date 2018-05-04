using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Essential.Unit4
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Unit4\n");
            Console.WriteLine(new String('-', 50));
            Ex1Demo();

            Console.WriteLine(new String('-', 50));
            Ex2Demo();

            Console.WriteLine(new String('-', 50));
            Ex3Demo();

            Console.ReadLine();
        }

        static void Ex1Demo()
        {
            Console.WriteLine("Task1\nChanged example with Abstract class");

            Title title = new Title();
            title.Content = "Контракт";

            Body body = new Body();
            body.Content = "Тело контракта...";

            Footer footer = new Footer();
            footer.Content = "Директор: Иванов И.И.";

            Document document = new Document(title, body, footer);
            document.Show();
        }

        static void Ex2Demo()
        {
            Console.WriteLine("Task2\nUsing Abstract classes");
            Handler docfile = new Handler("Report.txt");

            AbstractHandler dynamicFile = docfile.Handle();
//            docfile.Handle();

            if (dynamicFile != null)
            {
                dynamicFile.Create();
                dynamicFile.Change();
                dynamicFile.Open();
                dynamicFile.Save();
            }
            else
            {
                Console.WriteLine("You typed incorrect file name, instance was not created");
            }
        }

        static void Ex3Demo()
        {
            Console.WriteLine("Task3\nUsing Interfaces");
            Player dolby = new Player("Moscow calling");

            dolby.Record();
            (dolby as IRecordable).Pause();
            (dolby as IRecordable).Stop();

            dolby.Play();
            (dolby as IPlayable).Pause();
            (dolby as IPlayable).Stop();
        }
    }
}