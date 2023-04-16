using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLasswork_6
{
    public class Person
    {
     public string Name { get; set; }
 

        public Person() { }
        public Person(string name)
        {
            Name = name;
        }

        public  virtual void Showinfo()
        {
            Console.WriteLine(Name);
        }
    }
}
