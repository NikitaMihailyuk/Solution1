using Home_9;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_9
{
    public class Tasks
    {
        public ShowInfo showInfo = new ShowInfo();
        public PersonCreator creator = new PersonCreator();

        public void Task1 (List<Person> list)
        {
            Console.WriteLine("Show All persons which name starts with A ");

            var peopleStartsA = from person in list
                                where person.Name.StartsWith("A")
                                select person;

            List<Person> peopleStartsAList = peopleStartsA.ToList();
            showInfo.ShowPersonsInfo(peopleStartsAList);
        }

        public void Task2(List<Person> list)
        {
            Console.WriteLine("Show all who have salary > 100 and younger than 30 :");

            var peopleSalary = from person in list
                               where person.Salary > 1000 || person.Age < 30
                               select person;

            List<Person> peopleSalaryList = peopleSalary.ToList();
            showInfo.ShowPersonsInfo(peopleSalaryList);
        }

        public void Task3(List<Person> list)
        {
            Console.WriteLine("First oldman from persons");
            var oldPerson = list.Where(person => person.Age > 50).First();
            List<Person> oldPersonList = new List<Person>();
            oldPersonList.Add(oldPerson);
            showInfo.ShowPersonsInfo(oldPersonList);
        }


        public void Task4(List<Person> list)
        {
            try
            {
                list.AddRange(creator.WrongPersonCreates(list));
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
        }

    }
}
