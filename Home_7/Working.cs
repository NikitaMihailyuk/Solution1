using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_7
{
    public class Working
    {
    /// <summary>
    /// Logic for Employees 
    /// </summary>
      Showinfo showinfo= new Showinfo();
        public void Work(Employee[] employees)
        {
            foreach (Employee e in employees)
            {
               if (e.Profession == Profession.Cleaner)
                {
                    showinfo.ShowClean(e.Name, Profession.Cleaner);
                }
                if (e.Profession == Profession.Cook)
                {
                    showinfo.ShowCook(e.Name, Profession.Cook);
                }
                if (e.Profession == Profession.Manager)
                {
                    showinfo.ShowManager(e.Name, Profession.Manager);
                }
            }
        }
    }
}
