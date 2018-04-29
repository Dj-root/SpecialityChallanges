using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Essential.Unit3
{
    class ExcelentPupil : Pupil
    {

        public ExcelentPupil(string fname, string lname) : base(fname, lname) { }

        public override void Read()
        {
            Console.WriteLine("The Excelend Pupil reads a lot of books!");
        }

        public override void Relax()
        {
            Console.WriteLine("The Excelend Pupil is never relaxing...");
        }

        public override void Study()
        {
            Console.WriteLine("The Excelend Pupil are studying very well!");
        }

        public override void Write()
        {
            Console.WriteLine("The Excelend Pupil writes a lot of conspects!");
        }
    }
}
