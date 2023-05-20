using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Classwork10_1
{
    public class AppleStore
    {
        public event Action<List<Phone>> notify;
        // public  Action<List<Phone>> notify, togda eshe peredavat dannie 
        List<Phone> devices = new List<Phone>();
        public TextSender textSender;

        public AppleStore(Action<List<Phone>> method)
        {
        notify +=method; 
        }


        public void AddSubscriber(Action<List<Phone>> method) { notify += method; }


        public void PutNewPhones(List<Phone> phones)
        {
            devices.AddRange(phones);
            foreach (Phone phone in devices)
            {
                Console.WriteLine($"{phone.name} in sore for {phone.price}");

            }
            if (devices.Count < 10)
            {
                notify?.Invoke(devices);
            }
           
        }
    }
}
