using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_9
{
    public class ShowInfo
    {
        public void ShowPersonsInfo(List<Person> persons)
        {
            foreach (Person person in persons)
            {
                Console.WriteLine(person.Name);
                Console.WriteLine(person.Age);
                Console.WriteLine(person.Salary);
            }
        }

        public void ShowPersonsInfoEnum(IEnumerable<Person> people)
        {
            foreach (Person person in people)
            {
                Console.WriteLine(person.Name);
                Console.WriteLine(person.Age);
                Console.WriteLine(person.Salary);
            }
        }
    }
}
