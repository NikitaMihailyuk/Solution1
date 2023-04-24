using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_8
{
    public class Person
    {
        public string Name { get; set; }
        public double MaxNumberOfCalories { get; set; }

        public Person(string name, double maxNumberOfCalories)
        {
            Name = name;
            MaxNumberOfCalories = maxNumberOfCalories;
        }

    }
}
