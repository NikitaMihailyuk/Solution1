using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_7
{
    public class Showinfo
    {
        public void ShowCook(string name, Profession profession)
        {
            Cooks cook = new Cooks(name, profession);
            cook.ToString();
            cook.ToCook();
        }     
    }
}
