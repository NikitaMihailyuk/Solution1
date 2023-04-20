using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_7
{
    public class Managers : Employee, IMenegerable,ICookable 
    {
        public Managers(string name, Profession profession) : base(name, profession)
        { }


        public override string ToString()
        {
            return ("The manager is " + Name);
        }


        public void ToManage()
        {
            Console.WriteLine(Name + "is managing");
        }


        public void ToCook()
        {
            Console.WriteLine(Name + "is Cooking");
        }


        public void ToSolving()
        {
            {
                Console.WriteLine(Name + "is Solving");
            }
        }
    }
}

