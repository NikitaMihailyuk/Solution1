using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_7
{
    public class Showinfo
    {
        /// <summary>
        /// Show info about work if Employee is working 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="profession"></param>
        public void ShowCook(string name, Profession profession)
        {
            Cooks cook = new Cooks(name, profession);
            Console.WriteLine(cook.ToString());
            cook.ToCook();
            cook.ToClean();
        }


        public void ShowClean(string name, Profession profession)
        {
            Cleaners cleaner = new Cleaners(name, profession);
            Console.WriteLine(cleaner.ToString());
            cleaner.ToClean();
        }


        public void ShowManager(string name, Profession profession)
        {
            Managers manager = new Managers(name, profession);
            Console.WriteLine(manager.ToString());
            manager.ToCook();
            manager.ToManage();
            manager.ToSolving();
        }
    }
}
