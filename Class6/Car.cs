using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class6
{
    public class Car : IMoveable
    {
  
        public string Name { get; set; }    
        public Car(string name) {
            Name = name;
        }
 
          void IMoveable.Move()
        {
            IMoveable moveable = this;
            moveable.Move();
        }

        public override string ToString()
        {
            return base.ToString();
        }
        public override bool Equals(object obj)
        {
           if (obj == null && (obj is Car car))
            {
                return Name == car.Name;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }


        public override void SpendFuel()
        {
            Console.WriteLine(" Carf ");
        }
    }
}
