using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Home_7
{
    /* Реализовать систему работы ресторана Макдональдс.В системе должны быть следующие участники
Cleaner - уборщик, умеет убираться.
Cook - повар, умеет готовить и убираться
Менеджер - Умеет решать конфликты, готовить, управлять персоналом
Создать метод, который будет имитировать работу ресторана c выводом информации на консоль.
Ex(Manager is managing people
    Cook is cooking
    Cleaner is cleaning
    Manager is solving conflicts
    Manager is cooking.
    Cook is cleaning.)
Переопределить метод ToString() в каждом классе сотрудников ресторана. */
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonalCreator personalCreator = new PersonalCreator();
            Working working = new Working();

            //Create personal
            Employee[] pesonal = personalCreator.PersonalCreate();

            //work logic
            working.Work(pesonal);
            Console.ReadLine();
        }
    }
}
