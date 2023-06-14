using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Home_10
{
    public class linqtasks
    {

        public List<string> words = new List<string> { "hello", "Hi", "Applee", "ds", "1", "go go go", "bee" };
        public static UserCreator usercreator = new UserCreator();
        public List<User> users = usercreator.UserCreates().ToList();
        /*
         Linq
Реализовать следующие методы:
        */
        /// <summary>
        /// - Метод возвращает первое слово из последовательности слов, содержащее только одну букву.
        /// </summary>
        public void Task1()
        {
            Console.WriteLine("Task 1");
            var result = words.Where(w => w.Length == 1).FirstOrDefault();
            Console.WriteLine(result);
        }

        /// <summary>
        /// - метод, возвращающий последнее слово, содержащее в себе подстроку «ее». Реализовать, используя только 1 метод LINQ.
        /// </summary>
        public void Task2()
        {
            Console.WriteLine("Task 2");
            var result = words.Where(w => w.Contains("ee")).LastOrDefault();
            Console.WriteLine(result);
        }

        /// <summary>
        /// - Реализовать метод для возврата последнего слова, соответствующего условию: длина слова не меньше min и не больше max. Если нет слов, соответствующих условию, метод возвращает null.
        /// </summary>
        public void Task3()
        {
            Console.WriteLine("Task 3");
            var result = words.Where(w => w.Length >= 12 && w.Length < 9).LastOrDefault();
            if (result == null) Console.WriteLine("Result is null:" + result);
            Console.WriteLine(result);
        }

        /// <summary>
        /// - Напишите метод, который возвращает количество уникальных значений в массиве.
        /// </summary>
        public void Task4()
        {
            Console.WriteLine("Task 4");
            var result = words.Distinct().Count();
            Console.WriteLine(result);
        }

        /// <summary>
        /// - Напишите метод, который принимает список и извлекает значения с 5  элемента (включительно)  те значение которые содержат 3
        /// </summary>
        public void Task5()
        {
            Console.WriteLine("Task 5");
            var result = words.Skip(1).Where(w => w.Contains("e")).ToList() ;
            foreach (var item in result) Console.WriteLine(item);
        }


        /// <summary>
        /// - Метод возвращает длину самого короткого слова
        /// </summary>
        public void Task6()
        {
            Console.WriteLine("Task 6");
            var result = words.Min(w => w.Length);  
            Console.WriteLine(result);
        }

        ///- Напишите метод, который преобразует словарь в список и меняет местами каждый ключ и значение
        /// USER
        public void Task7()
        {
            Console.WriteLine(" task 7. I don't know yet how to do tasks in this context");
        }

        ///- Напишите метод, который возвращает "<FirstName> <MiddleName> <LastName>", если отчество присутствует Или "<FirstName> <LastName>", если отчество отсутствует.
        /// USER
        public void Task8()
        {
            Console.WriteLine("Task 8");
            foreach (User user in users)
            {
                if (user.LastName == null) Console.WriteLine(user.FirstName + " " + user.MiddleName + " dont have lastname");
                Console.WriteLine(user.FirstName + " " + user.MiddleName + " " + user.LastName);
            }
        }

        ///
        /// -Напишите метод, который возвращает предоставленный список пользователей, упорядоченный по LastName в порядке убывания.
        /// USER
        public void Task9()
        {
            Console.WriteLine("Task 9");
            var users1 = users.OrderByDescending(x => x.LastName).ToList();
            foreach (User user in users1)
            {
                Console.WriteLine(user.FirstName + " " + user.MiddleName + " " + user.LastName);
            }
        }



    }
}
