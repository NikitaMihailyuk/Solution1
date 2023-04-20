using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_7
{
     public class Cooks : Employee, ICookable, ICleanerable
    {
       
        public Cooks(string name, Profession profession) : base(name, profession)
        {

        }
        public override string ToString()
        { 
            return ("The Cook "+base.ToString());
        }

            public void ToCook()
        {
            Console.WriteLine(Name + " is Cooking");
        }
        public void ToClean()
        {
            Console.WriteLine();
        }
    }
}
