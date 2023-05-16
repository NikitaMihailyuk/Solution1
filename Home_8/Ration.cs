using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_8
{
    public class Ration
    {
        public string ProductName { get; set; }
        public double Callories { get; set; }

        public Ration(string productName, double callories) 
        { 
            ProductName = productName;
            Callories = callories;
        }
    }
}
