using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_8_3
{
    public class MobilePhone
    {
        public Dictionary<Contact, string> ContactPhones {  get; set; }
        public MobilePhone(Dictionary<Contact, string> contactPhones)
        {
            ContactPhones = contactPhones;
        }

        public string GetNumber(Contact contact)
        {
            if (ContactPhones.ContainsKey(contact))
            {
                return ContactPhones[contact];
            }
            return "1234";
        }
    }
}
