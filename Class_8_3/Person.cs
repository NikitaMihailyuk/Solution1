using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_8_3
{
    public class Person
    {
        public int Id { get; set; }

        public Person(int id)
        {
            Id = id;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return base.Equals(Id);
        }
        
    }
}
