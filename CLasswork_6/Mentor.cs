using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLasswork_6
{
    public class Mentor : Person
    {

        public Discipline Discipline { get; set; }

        public Mentor(string name , Discipline discipline) : base(name)
        {
            Discipline = discipline;    
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            
            Console.WriteLine(" Discipline " + Discipline);
            ShowClassInfo();
        }

        public void ShowClassInfo()
        {
            Console.WriteLine(PrepareClass());

        }

        private string PrepareClass()
        {
            return "prapered class";
        }
    }
}
