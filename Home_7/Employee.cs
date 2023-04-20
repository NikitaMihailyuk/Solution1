using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_7
{
    public class Employee
    {
        public string Name { get; set; }
        public Profession Profession { get; set; }


        public Employee(string name, Profession profession) 
        {
            Name = name;
            Profession = profession;
        }
    }
}
