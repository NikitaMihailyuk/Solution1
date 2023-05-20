using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Home_10
{
    internal class Program
    {
        /*
        Delegate and Event
1. Cоздать класс мониторинга средней цен на жилье, цена будет генерироваться с помощью класса рандом и
  выдавать случайное значение в определенном диапазоне. 
 Для того чтобы вывод цены был удобен пользователю в классе мониторинга создать поле делегат,
 обьект которого будет создаваться в классе мониторинга. Пользователь указывает метод для отображения цены в
удобном ему формате путем передачи метода в конструктор класса мониторинга.

пример создания бьекта монитора.
PriceMonitor monitor = new PriceMonitor(ShowPrice);
public static void ShowPrice(int price)
{
  //your code
}
2. Реализовать паттерн наблюдатель в случае если цена на жилье опустилась ниже определенного значения, и сообщить всем кто на это событие подписался. 
* реализовать как через событие так и через паттерн наблюдатель без событи
https://refactoring.guru/ru/design-patterns/observer

Linq
Реализовать следующие методы:
- Метод возвращает первое слово из последовательности слов, содержащее только одну букву.
- метод, возвращающий последнее слово, содержащее в себе подстроку «ее». Реализовать, используя только 1 метод LINQ.
- Реализовать метод для возврата последнего слова, соответствующего условию: длина слова не меньше min и не больше max. Если нет слов, соответствующих условию, метод возвращает null.
- Напишите метод, который возвращает количество уникальных значений в массиве.
- Напишите метод, который принимает список и извлекает значения с 5  элемента (включительно)  те значение которые содержат 3
- Метод возвращает длину самого короткого слова
- Напишите метод, который преобразует словарь в список и меняет местами каждый ключ и значение

дан класс
public class User
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }

        public User(string firstName, string middleName, string lastName)
        {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
        }
    }
- Напишите метод, который возвращает "<FirstName> <MiddleName> <LastName>", если отчество присутствует Или "<FirstName> <LastName>", если отчество отсутствует.
-Напишите метод, который возвращает предоставленный список пользователей, упорядоченный по LastName в порядке убывания.

        */
        static void Main(string[] args)
        {
            PriceMonitor priceMonitor = new PriceMonitor();
            HomeCreator creator = new HomeCreator();
            Listner1 listner1 = new Listner1();
            Listner2 listner2 = new Listner2();

            Home[] homes = creator.HomeCreates();
            Console.WriteLine("_______________________________________");
            Console.WriteLine("Show low Price \n");
            priceMonitor.LogicPrice(homes, Typeinfo.Min);

            Console.WriteLine("_______________________________________");
            Console.WriteLine("Show Max Price \n");
            priceMonitor.LogicPrice(homes, Typeinfo.Max);

            Console.WriteLine("_______________________________________");
            Console.WriteLine("Show Avarage Price and all \n");
            priceMonitor.LogicPrice(homes, Typeinfo.Avarage);


            /// Price go down
            priceMonitor.notify += listner1.SellNotification;
            priceMonitor.notify += listner2.SellNotification;
            priceMonitor.PriceGoDown(homes); 
     
            Console.ReadKey();
        }
    }
}
