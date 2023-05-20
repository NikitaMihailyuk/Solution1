using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_10
{
    public class Listner2
    {
        public void SellNotification(Home Homes)
        {
            {
                Console.WriteLine(" Listener2,see that price " + Homes.Price + " on Adress" + Homes.Adress);
            }
        }
    }
}
