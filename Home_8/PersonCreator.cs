using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_8
{
    public class PersonCreator
    {
        public Person[] PersonCreates()
        {
            Person[] persons = {
                        new Person("Tom Cruise ", 2300),
                        new Person("John Hill", 2500),
                        new Person("Ben Affleck", 2200)
                         };
            return persons;
        }
    }
}

