using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_8_3
{
    public class Week : IEnumerable
    {
        private string[] days = { "mon", "Thur", "wedn" };
        

        public IEnumerator GetEnumerator()
        {
           return days.GetEnumerator();
        }
    }
}
