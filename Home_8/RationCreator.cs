using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_8
{
    public class RationCreator
    {


        public void RationCreate()
        {

            PersonCreator personCreator = new PersonCreator();
            Person[] persons = personCreator.PersonCreates();
            
             
        }

        public Ration[] Rations()
        {
            Ration[] rations =
            {
                new Ration("Овсянка на молоке ", 300),
                new Ration("Фруктовый салат", 120),
                new Ration("Полноценный сэндвич с курицей и овощами", 400),
                 new Ration("Рыбный пирог", 250),
                new Ration("Фаршированные перцы", 350),
                new Ration("Винегрет с масло", 200),
                 new Ration("Греческий салат ", 250),
                new Ration("Щи из свежей капусты", 100),
                new Ration("Фасолевый суп", 250),
                 new Ration("Пицца с томатным соусом и овощами", 350),
                new Ration("Куриный паровой котлет", 150),
                new Ration("Паста с тунцом и помидорами", 400),
                   new Ration("Жареный рис с овощами и яйцом", 350),
                 new Ration("Суп «Минестроне»", 200),
                new Ration("Омлет с грибами", 250),
                new Ration("Куриный салат с авокадо и листовым салатом", 300),
                 new Ration("Вареные креветки", 80),
                 new Ration("Строганов из говядины»", 350),
                new Ration("Греческий йогурт с фруктами и орехами", 200),
                new Ration("Салат «Цезарь» с запечённой курицей", 450)
            };
            return rations;
        }
        public List<Ration> RationRandomize()
        {
            List<Ration> menu = new List<Ration>();
            Ration[] rations = Rations();
            int[] array = new int[10];


            // создаем новый массив из 10 элементов
            // заполнение массива рандомными значениями
            int randomNumber = 1;
            bool exists;
            for (int i = 0; i < array.Length; i++)
            {
                do // генерируем числа, пока не найдем уникальное
                {
                    exists = false;
                    randomNumber = new Random().Next(0, 20); // случайное число от 1 до 20

                    for (int j = 0; j < i; j++) // проверяем, есть ли такое число уже в массиве
                    {
                        if (array[j] == randomNumber)
                        {
                            exists = true; // если да, генерируем новое число
                            break;
                        }
                    }
                } while (exists);
                menu.Add(rations[randomNumber]);
            }
            return menu;
        }

        public Dictionary<string, Ration> WeekRation()
        {
            w
            return 
        }
    }
}