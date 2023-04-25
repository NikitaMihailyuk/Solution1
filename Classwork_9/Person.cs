using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork_9
{
  
    public class Person
    {
        private int age;

        public  string Name { get; set; }

        public int Age { 
        get { return age; } set 
            { 
                if (value <18)
                {
                    throw new PersonException("wtf no 18", Age);
                }
                age = value; }
        }
       
        public Person(string name, int age) {
        Name = name;
            Age = age;
        }
    }
}
