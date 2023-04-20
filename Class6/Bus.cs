using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class6
{
    public class Bus : Transport, ind
    {
        public override int Capacity { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Bus(string name) : base(name)
        {
        }

        public override void GetPeopleToTheDestination()
        {
            Console.WriteLine("Car is getting");
        }

   

    }
}
