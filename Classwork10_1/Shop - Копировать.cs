using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork10_1
{
    public class Shop2
    {

        public void SellNotification(List<Phone> phones)
        {
            foreach (Phone phone in phones)
            {
                Console.WriteLine($"{phone.name} in store for {phone.price + 299} at shop2");
            }
          
        }
    }
}
