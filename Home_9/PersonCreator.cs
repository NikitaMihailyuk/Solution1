using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_9
{
    public class PersonCreator
    {
        public Person[] PersonCreates()
        {
            Person[] persons = {
                        new Person("Tom Cruise", 22, 55550.32),
                        new Person("Aohn Hill", 52, 35550.32),
                        new Person("Tom Cruise2", 51, 0),
                        new Person("Ben Affleck", 32, 45550.32)
                         };
            return persons;
        }

        public  List<Person> PersonCreates(List<Person> people)
        {

            try
            {
                people.AddRange(new Person[] { new Person("Tom Cruise", 22, 55550.32) });
            }
            catch (SalaryException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (AgeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return new List<Person>();
        }
    }
}
