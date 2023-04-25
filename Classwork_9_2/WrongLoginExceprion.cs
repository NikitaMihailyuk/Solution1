using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork_9_2
{
    public class WrongLoginExceprion : Exception
    {
        public WrongLoginExceprion(string message): base(message)
        {
        }
    }
}
