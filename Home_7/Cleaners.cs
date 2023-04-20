using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_7
{
    public class Cleaners : Employee, ICleanerable
    {
        public Cleaners(string name, Profession profession) : base(name, profession)
        { }


        public override string ToString()
        {
            return ("The Cleaner is " + Name);
        }


        public void ToClean()
        {
            Console.WriteLine(Name + " is cleaning");
        }
    }
}
