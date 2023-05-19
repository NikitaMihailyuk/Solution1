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

        public  List<Person> WrongPersonCreates(List<Person> people)
        {

            List<Person> WrongPerson = new List<Person> { new Person("123", 323, 231) };
            
            foreach (Person person  in WrongPerson)
            
            { if (person.Age < 18)
                    throw new AgeException("not 18");
                if (person.Salary < 1000)
                    throw new SalaryException("salary not ok");
            }
            try
            {
                people.AddRange(WrongPerson);
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
            return people;
        }
    }
}
