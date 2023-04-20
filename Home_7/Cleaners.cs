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
        {

        }

        public void ToClean()
        {
            Console.WriteLine();
            Console.WriteLine(Name + " is Cleaning");
        }
    }
}
