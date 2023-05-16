using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork10_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var appleStore = new AppleStore();
            var shop = new Shop();
            var shop2 = new Shop2();
            appleStore.notify += shop.SellNotification;
            appleStore.notify += shop2.SellNotification;
            List<Phone> phones = new List<Phone>()
            {
                new Phone("iphone 13",800),
                new Phone("iphone 13 max",900),
                new Phone("iphone 14",1000),
                new Phone("iphone 14 max",1100)
            };

            var result = phones.Select(x => x.name.Contains("max"));
            Console.WriteLine(result);
            
            var resultPH = phones.Where(x=> x.name.Contains("max"));
            foreach (Phone phone in resultPH)
            {
                Console.WriteLine(phone.name);
            }
            var phonet = phones.Where(x => x.name.StartsWith("max")).Count();
            var phonesorted = phones.Where(x => x.name.EndsWith("max")).OrderBy(x => x);

            appleStore.PutNewPhones(phones);
           Console.ReadLine();

        }
    }
}
