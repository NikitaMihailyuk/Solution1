using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork_9
{
    public class Class1
    {
        public void dfd()
        {
            List<string> names = new List<string>() { "213","2143545","24325"};

            var peopleWithNames = from name in names
                                  where name.StartsWith("A")
                                  select name;
            foreach (var people in peopleWithNames)
            {
                Console.WriteLine(people);
            }

                peopleWithNames = from name in names
                                  where name.Length==4
                                  select name;
            /////
            ///
               peopleWithNames= names.Where(p => p.StartsWith("A"));

               var fdsf = names.First(p1 => p1.StartsWith("A"));

            List<Person> names2 = new List<Person>() { new Person("213",12) };
            var sdf = names2.Where(person => person.Age > 20).Select(person => person.Name);
            int sum = names2.Sum();


        }
    }
}
