using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_9
{
    internal class Program
    {

        /* <summary>
        /// дз
        Создайте коллекцию состояющую из объектов Person(поля Name, Age, Salary)
    Выведите всех Person, чье имя начинается на A
    Выведите всех Person, у кого зп больше 1000 и возраст меньше 30. 
    Выведите первого человека старше 50 
    Добавьте свои классы исключений - SalaryException, AgeException и добавьте в поля Age и Salary проверку, 
    если Age меньше 18 - сгенерируйте исключение, если salary меньше 100 - сгенерируйте исключение
    Обработайте исключения
       */

        static void Main(string[] args)
        {
            PersonCreator personCreator = new PersonCreator();
            List<Person> persons = new List<Person>();
            persons.AddRange(personCreator.PersonCreates());
            ShowInfo showInfo = new ShowInfo();
            showInfo.ShowPersonsInfo(persons);
            /////

            Console.WriteLine("With a:");
            var peopleStartsA = from person in persons
                                where person.Name.StartsWith("A")
                                select person;
            showInfo.ShowPersonsInfoEnum(peopleStartsA);

            Console.WriteLine("bank:");
            var peopleSalary = from person in persons
                               where person.Salary > 1000 || person.Age < 30
                               select person;

            showInfo.ShowPersonsInfoEnum(peopleSalary);
            Console.WriteLine("OLDMAN:");
            var oldPerson = persons.Where(person => person.Age>50).First();
            Console.WriteLine(oldPerson.Name);


            ///some exeption 
             persons.AddRange(personCreator.WrongPersonCreates(persons));
            Console.ReadLine();
        }
    }
}
