using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_7
{
    public class Working
    {
      Showinfo showinfo= new Showinfo();
        public void Work(Employee[] employees)
        {
            foreach (Employee e in employees)
            {
               if (e.Profession == Profession.Cleaner)
                {
                    Cleaners cleaner = new Cleaners(e.Name, Profession.Cleaner);
                    cleaner.ToString();
                    cleaner.ToClean();
                }
                if (e.Profession == Profession.Cook)
                {
                    Cooks cook = new Cooks(e.Name, Profession.Cook);
                                 
                    cook.ToCook(); 
                    cook.ToClean();
                    showinfo.ShowCook(e.Name, e.Profession);
                   
                }
                if (e.Profession == Profession.Manager)
                {
                    Managers manager = new Managers(e.Name, Profession.Manager);
                    manager.ToCook();
                    manager.ToSolving();
                    manager.ToManage();
                }
            }
              
             
 

        }

        public void WorkPerson()
        {
         
        }


    }
}
