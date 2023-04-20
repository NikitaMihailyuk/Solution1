using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class6
{
    public class RobotDoctor : ITreateble
    {
        public void Treat()
        {
            Console.WriteLine("Robot");
        }
    }
}
