using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_7
{
    public class PersonalCreator
    {
        public Employee[] PersonalCreate()
        {
            {
                Employee[] employees = {
                        new Employee("Tom Cruise ", Profession.Manager),
                        new Employee("John Hill", Profession.Cook),
                        new Employee("Ben Affleck", Profession.Cleaner)
                    };
                return employees;
            }
        }
    }
}

