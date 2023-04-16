using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLasswork_6
{
    public class Student1 : Person
    {

        public string Name { get; set; }
        public Discepline Discepline { get; set; }
        public int Mark {get; set; }

        public Student1(string name, Operation discepline, int mark)
        {
            Name = Name;
            Discepline = Discepline;
            Mark = Mark;
        }
        public override void ShowInfo()
        {
            Console.WriteLine(" des " + Discepline);
        }
    }
}
