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
                Console.WriteLine("______________________________");
                Console.WriteLine("The name is: " + person.Name);
                Console.WriteLine("Tha age: "+ person.Age);
                Console.WriteLine("The Salary:"+person.Salary);
                Console.WriteLine("______________________________");
            }
        }
    }
}
