using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Essential.Unit3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ex1Demo();
            Console.WriteLine(new String('-', 50));
            Ex2Demo();

            Console.WriteLine(new String('-', 50));
            Ex3Demo();


            Console.ReadLine();
        }

        public static void Ex1Demo()
        {
            Printer basePrn = new Printer();
            basePrn.Print("This is message for Base Class");
        }

        public static void Ex2Demo() {

            Pupil ivan = new ExcelentPupil("Ivan", "Ivanov");
            Pupil petr = new GoodPupil("Petr", "Petrov");
            Pupil john = new GoodPupil("John", "Dou");
            Pupil vova = new BadPupil("Vovochka", "Sidorov");

            ClassRoom iClass = new ClassRoom(ivan, petr, john, vova);
            iClass.ShowClassActivily();
        }

        public static void Ex3Demo() {

            Vehicle bmw = new Car(50.451877, 30.523842, 3500, 155, 2010);
            Car mers = new Car(0, 0, 15000, 250, 2016);

            Vehicle liner = new Ship(46.440158, 30.852383, 1685800, 30, 1995, 500, "Odessa");
            Vehicle yacht = new Ship(0, 0, 685800,20, 2017, 4, "New Orlean");

            Vehicle su27 = new Plane(0, 0, 30000000, 2500, 1985, 0, 0);
            Vehicle boieng = new Plane(0, 0, 290000000, 940, 2017, 15000, 250);
            Vehicle an2 = new Plane(50.451877, 30.523842, 220000, 250, 1960, 4400, 20);

            Vehicle.GetInfo(bmw);
            Vehicle.GetInfo(mers);
            Vehicle.GetInfo(liner);
            Vehicle.GetInfo(yacht);
            Vehicle.GetInfo(su27);
            Vehicle.GetInfo(boieng);
            Vehicle.GetInfo(an2);


            //Vehicle.GetInfo

        }


    }
}
