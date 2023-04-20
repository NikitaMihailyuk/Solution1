using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class6
{
    public abstract class Transport
    {
        public abstract int Capacity { get; set; }
        public string Name { get; set; }
        public Transport(string name)
        {
            Name = name;
        }
        public abstract void GetPeopleToTheDestination();

        public virtual void SpendFuel()
        {
            Console.WriteLine(" Fuel is spending ");
        }
        public void DoFuel()
        {
        }
        public static void SpendFuel1()
        {
            {

            }
        }

    }
}
