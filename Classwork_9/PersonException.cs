using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork_9 
{
    public class PersonException : Exception
    {

        public int Age { get; }

        public PersonException(string message, int age) :base(message) 
        {
            Age = age;
        }
    }
}
