using Home_9;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_9
{
    public class Program
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
            ///create persons in list 
            PersonCreator personCreator = new PersonCreator();
            List<Person> persons = new List<Person>();
            persons.AddRange(personCreator.PersonCreates());
            ShowInfo showInfo = new ShowInfo();

            ///Show all persons
            showInfo.ShowPersonsInfo(persons);

            /// Tasks
            Tasks tasks = new Tasks();
            tasks.Task1(persons);
            tasks.Task2(persons);
            tasks.Task3(persons);
            tasks.Task4(persons);

            Console.ReadLine();
        }
    }
}
