using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_8_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person(1);
            person.Id = 1;
            Person person2 = new Person(2);
            person2.Id = 10;

            Dictionary<Person, string> map = new Dictionary<Person, string>()
            {
               [person]= "First"
            };

            Dictionary<Contact, string> contacts = new Dictionary<Contact, string>()
            {
                [Contact.Andrey] = "+7123213",
                [Contact.Dima] = "+7123213",
                [Contact.Max] = "+7123213"
            };
            List<>


            Person person1 = new Person(1);
            person1.Id = 1;
            person1.

            MobilePhone phone = new MobilePhone(contacts);
            string number = phone.GetNumber(Contact.Dima);

            Dictionary<int, string> personsId = new Dictionary<int, string>();
            personsId.Add(person.Id, person.Name);

            var people = new Stack<string>();  
            var people1 = new Queue<string>();

            Week week = new Week();
            foreach (string day in week)
            {
                Console.WriteLine(day);
            }


        }
    }
}
