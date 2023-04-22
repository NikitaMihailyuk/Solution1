using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork_8
{
    public class Stype<T> : Person<T>
    {
        public override T DoSomething()
        {
            return Value;
        }
    }
}
