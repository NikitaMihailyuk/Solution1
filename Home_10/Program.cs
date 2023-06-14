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
 */

        static void Main(string[] args)
        {
            PriceMonitor priceMonitor = new PriceMonitor();
            HomeCreator creator = new HomeCreator();
            Listner1 listner1 = new Listner1();
            Listner2 listner2 = new Listner2();
            linqtasks linqtasks = new linqtasks();

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

  
            /// linq Tasks
            linqtasks.Task1();
            linqtasks.Task2();
            linqtasks.Task3();
            linqtasks.Task4();
            linqtasks.Task5();
            linqtasks.Task6();
            linqtasks.Task7();
            linqtasks.Task8();

            Console.ReadKey();
        }

        

    }
}
