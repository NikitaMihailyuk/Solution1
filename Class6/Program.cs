using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Transport car = new Car("123");
            Transport bus = new Car("123");
            GetPeople(car);
            GetPeople(bus);
            Transport.SpendFuel1();

            IEatable eatable = new Doctor();
            Eat(eatable);
            Object bj = new Car("123");
            car.ToString();



        }


        public static void GetPeople(Transport transport)
        {
            transport.GetPeopleToTheDestination();
        }
        public static void Eat(IEatable eatable)
        {
            eatable.Eat();
        }
    }
}
