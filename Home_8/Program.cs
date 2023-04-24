using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Home_8
{
    internal class Program
    {


/* Составьте рацион питания для человека на неделю(Person - Содержит поля Name, MaxNumberOfCalories
 * (Макс Количество-калорий потребляемых за день)).
Cам рацион представляет пару ключ(День недели(Enum) - значение (список продуктов) - List.
Продукт содержит поля: название продукта, Количество калорий (1 class Product)
Составьте рацион произвольным образом(пример: создайте класс RationCreator и добавьте в него метод по созданию рациона)
на каждый день и назначьте его Person.
Добавьте метод в классе Person, который проверит рацион на каждый день и если в какой-то день общее количество калорий превышает максимальное,
будет удалять продукты из списка, пока сумма их калорий будет меньше либо равна
максимальному количеству калорий, потребляемых человеком за день. */
        static void Main(string[] args)
        {
            RationCreator creator = new RationCreator();
            Dictionary<string, List<Ration>> ration = creator.WeekRation();
            Console.WriteLine(ration.Keys.First());
            foreach (var key in ration)
            {
                Console.WriteLine(ration.Values.ToString());
            }
            
            Console.ReadLine();
        }
    }
}
