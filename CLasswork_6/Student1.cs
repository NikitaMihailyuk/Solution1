using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLasswork_6
{
    public class Student1 : Person
    {

        public int Mark {get; set; }

        public Student1(string name, int mark) : base(name)
        {
            Mark = mark;
        }
        public  override void ShowInfo()
        {
            base.ShowInfo();

            Console.WriteLine(" Mark " + Mark);
        }

    }
}
