using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_9
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }
        public Person(string name, int age, double salary)
        {
            Name = name;
            Age = age;
            Salary = salary;
        }
    }
}
