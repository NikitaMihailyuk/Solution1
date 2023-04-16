using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLasswork_6
{
    public class Student : Person
    {
        public string Group { get; set; }
        public Student(string group, string name) : base(name)
        {
            Group = group;
        }

     //   public new void Showinfo() //перекрытие
    //    {
     //       Console.WriteLine("dsd");
     //       Showinfo();
     //   }
        public sealed override void Showinfo() //перекрытие
        {
            base.Showinfo();
            Console.WriteLine("dsd");
        }
    }
}
