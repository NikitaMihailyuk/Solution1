using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork_8
{
    public class s2class <K, J> : Person<J, K> where J : class
    {
        public J SuperValue { get; set; }

    }
}
