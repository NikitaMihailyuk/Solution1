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
        public override string ToString()
        {
            return("The Cleaner " + base.ToString());
        }

        public void ToClean()
        {
            string infoclean =(Name + " is Cleaning");
            infoclean = infoclean.ToString();
            Console.WriteLine(infoclean);
        }
    }
}
