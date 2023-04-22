using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork_8
{
    public class  Person <T> 
    {
        public T Value { get; set; }
        public T addValue()
        {

            return Value;
        }
        public virtual DoSomething(int T)
        {
            return 2;
        }
    }
}
