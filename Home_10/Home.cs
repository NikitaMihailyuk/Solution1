using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_10
{
    public class Home
    {
        public string Adress { get; set; }
        public int Price { get; set; }
        public Home(string adress, int price)
        {
            Adress = adress;
            Price = price;
        }

    }
}
