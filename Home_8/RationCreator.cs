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
        /// <summary>
        /// All Dishes of ration with callories
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Make ration from random in 10 dishes from 
        /// </summary>
        /// <returns></returns>
        public List<Ration> RationRandomize()
        {
            List<Ration> menu = new List<Ration>();
            Ration[] rations = Rations();
            int[] array = new int[10];
            int randomNumber = new Random().Next(0, 20);
            bool exists;

            for (int i = 0; i < array.Length; i++)
            {
                randomNumber = new Random().Next(0, 20);
                exists = true;
                do // new random number if dishes was contains in ration
                {
                    if (menu.Contains(rations[randomNumber]) == false)
                    {
                        exists = false; 
                    }
                    randomNumber = new Random().Next(0, 20);
                }
                while (exists == true);
                menu.Add(rations[randomNumber]);
            }
            return menu;
        }

        /// <summary>
        /// create Random dishes on week 
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, List<Ration>> WeekRation()
        {
            string[] arrays = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            Dictionary<string, List<Ration>> weekRation = new Dictionary<string, List<Ration>>();

            foreach (string s in arrays)
            {
                weekRation.Add(s, RationRandomize());
            }
            return weekRation;
        }


        /// <summary>
        /// Delete some dishes if callories more than max
        /// temporary solution coz bad 
        /// </summary>
        /// <param name="maxCallories"></param>
        /// <param name="rations"></param>
        /// <returns></returns>
        public Dictionary<String, List<Ration>> RationCorrector(double maxCallories, Dictionary<string, List<Ration>> rations)
        {
            Console.WriteLine(maxCallories);

            foreach (KeyValuePair<string, List<Ration>> pair in rations)
            {
                int index = 0;
                double maxCall = 0;
                foreach (var val in pair.Value)
                {
                    maxCall += val.Callories;

                    if (maxCall >= maxCallories)
                    {
                        index++;
                    }
                }
                //delete dishes
                for (int i = 0; i < index; i++)
                {
                    rations[pair.Key].Remove(pair.Value[i]);
                }
            }
            return rations;
        }
    }
}