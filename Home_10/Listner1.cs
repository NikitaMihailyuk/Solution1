using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Home_10
{
    public class Listner1
    {

        public void SellNotification(Home Homes)
        {
            {
                Console.WriteLine(" Listener1,see that price " + Homes.Price + " on Adress" + Homes.Adress);
            }
        }
    }
}
