using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_9
{
    public class PersonCreator
    {
        /// <summary>
        /// All persons in massive in begin
        /// </summary>
        /// <returns></returns>
        public Person[] PersonCreates()
        {
            Person[] persons = {
                        new Person("Tom Cruise", 22, 55550.32),
                        new Person("Anton Hill", 52, 15550.12),
                        new Person("Anny Smith", 32, 35550.12),
                        new Person("Tom Zelath", 51, 235550.42),
                         new Person("Aoi Soma", 41, 235550.42),
                        new Person("Ben Affleck", 32, 45550.32)};
            return persons;
        }

        /// <summary>
        /// Try add persons with Exception
        /// </summary>
        /// <param name="people"></param>
        /// <returns></returns>
        /// <exception cref="AgeException"></exception>
        /// <exception cref="SalaryException"></exception>
        public List<Person> WrongPersonCreates(List<Person> people)
        {
            List<Person> WrongPersons = new List<Person>
          { new Person("Sam bad Salary", 19, 199),
            new Person("Yonger Person", 11, 231) };

            foreach (Person person in WrongPersons)
            {
                if (person.Age < 18)
                    throw new AgeException("New pesons Age yonger than 18");
                if (person.Salary < 100)
                    throw new SalaryException("New persons less 100");
            }

            people.AddRange(WrongPersons);
            return people;
        }
    }
}
