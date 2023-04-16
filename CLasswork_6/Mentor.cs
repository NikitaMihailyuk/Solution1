using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLasswork_6
{
    internal class Mentor
    {
        public string Name { get; set; }
        public Discepline Discepline { get; set; }

        public Mentor() {
            Name = Name;
            Discepline = Discepline;    
        }
        public  void ShowInfo()
        {
            Console.WriteLine(" des " + Discepline);
        }
    }
}
