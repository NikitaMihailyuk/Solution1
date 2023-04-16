using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLasswork_6
{
    public sealed class SpecialStudent : Student
    {

        public string Secret { get; set; }

        public SpecialStudent ( string name, string group, string secret) : base (name, group)
         {
            Secret = secret ;

            }
        public void Showinfo()
        {
            base.ShowInfo();
            Console.WriteLine(Secret);
        }


    }
}
