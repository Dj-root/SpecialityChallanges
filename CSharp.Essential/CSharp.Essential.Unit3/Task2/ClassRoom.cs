using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Essential.Unit3
{
    class ClassRoom
    {
        Pupil[] pupils;


        public ClassRoom(Pupil pupil1, Pupil pupil2, Pupil pupil3, Pupil pupil4)
        {
            pupils = new Pupil[4] { pupil1, pupil2, pupil3, pupil4};
        }

        public ClassRoom(Pupil pupil1, Pupil pupil2, Pupil pupil3)
        {
            pupils = new Pupil[3] { pupil1, pupil2, pupil3 };
        }

    public ClassRoom(Pupil pupil1, Pupil pupil2)   
        {
            pupils = new Pupil[2] { pupil1, pupil2};
        }


        public void ShowClassActivily()
        {
            foreach (Pupil pupil in pupils)
            {
                Console.WriteLine(new string('-', 50));
                Console.WriteLine("Pupil's name: {0} {1}", pupil.FirstName, pupil.LastName);
                pupil.Read();
                pupil.Write();
                pupil.Study();
                pupil.Relax();
            }
        }


        // void ShowActivity(Pupil pupil)
        //{
        //    pupil.Read();
        //    pupil.Write();
        //    pupil.Study();
        //    pupil.Relax();
        //}
    }
}
