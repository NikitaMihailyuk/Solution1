using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork_5
{
    public class Student
    {
        public string Name { get; set; }
        public string Group { get; set; }
        public int Mark { get; set; }

        public Student(string name,string group, int mark)
        {
            Name = name;
            Group = group;
            Mark = mark;
        }
    }
}
