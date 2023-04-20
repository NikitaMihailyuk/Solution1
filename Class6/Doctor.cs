using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class6
{
    public class Doctor  : Person,ITreateble, IEatable
    {
        public void Eat()
        {
            Console.WriteLine("43");
        }

        public void Treat()
        {
            Console.WriteLine("43");
        }
    }
}
