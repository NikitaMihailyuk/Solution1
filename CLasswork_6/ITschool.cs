using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLasswork_6
{
    public class ITschool
    {

        public string Title { get; set; }
        public Mentor Mentor { get; set; }
        public  Course Course { get; set; }
        public ITschool(string title, Mentor mentor, Course course)
        {
            Title = title;
            Mentor = mentor; 
            Course = course;
        }

        public void ShowInfo()
        {
            Console.WriteLine("IT SCHOOL " + Title);
            Mentor.ShowInfo();
            Course.ShowInfo();
        }

    }
}
