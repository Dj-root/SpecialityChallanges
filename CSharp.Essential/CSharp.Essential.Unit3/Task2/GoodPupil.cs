using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Essential.Unit3
{
    class GoodPupil : Pupil
    {

        public GoodPupil(string fname, string lname) : base(fname, lname) { }

        public override void Read()
        {
            Console.WriteLine("The Good Pupil reads books as well!");
        }

        public override void Relax()
        {
            Console.WriteLine("The Good Pupil can combine relaxing and education");
        }

        public override void Study()
        {
            Console.WriteLine("The Good Pupil is studying as well!");
        }

        public override void Write()
        {
            Console.WriteLine("The Good Pupil has good writing skills!");
        }
    }
}
