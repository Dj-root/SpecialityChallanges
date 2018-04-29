using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Essential.Unit3
{
    class BadPupil : Pupil
    {

        public BadPupil(string fname, string lname) : base(fname, lname)
        {
        }

        public override void Read()
        {
            Console.WriteLine("The Bad Pupil doesn't read books as well!");
        }

        public override void Relax()
        {
            Console.WriteLine("The Bad Pupil relaxing as well on regular basis...");
        }

        public override void Study()
        {
            Console.WriteLine("The Bad Pupil doesn't study as well!");
        }

        public override void Write()
        {
            Console.WriteLine("The Bad Pupil writes little bit!");
        }
    }
}
