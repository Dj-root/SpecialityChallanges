using System;
using CSharp.Essential.Unit18.Task1;
using CSharp.Essential.Unit15;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Essential.Unit18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unit 16 tasks");
            Console.WriteLine(new String('-', 50));

            Ex1Demo();
            Console.WriteLine(new String('-', 50));
            //Ex2Demo();
            //Console.WriteLine(new String('-', 50));
            //Ex3Demo();
            Console.WriteLine(new String('-', 50));
            //Ex4Demo();
            Console.WriteLine(new String('-', 50));
            //Ex5Demo();
            Console.ReadLine();
        }

        static void Ex1Demo()
        {
            Console.WriteLine("Task 1");

            MyClass myInst = new MyClass();
            myInst.Method();
        }
    }
}
