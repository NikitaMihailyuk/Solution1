using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_5
{
    public class Student
    {
        public int reward;
        public int Id { get; set;}
        public string Name { get; set; }
        public string Group { get; set; }
        public int MathMark {get; set; }
        public int PhysicalEducationMark { get; set; }
        public int BiologyMark { get; set; }
        public int Reward
        {
            get
            { return reward; }
            set
            {
                if (value < 0)
                {
                    reward = 1;
                }
                reward = value;
            }
        }
            
        public Student(string name, string group, int id, int mathMark, int physicalEducationMark, int biologyMark, int reward)
        {
            Name = name;
            Group = group;
            Id=id;
            MathMark = mathMark;
            PhysicalEducationMark = physicalEducationMark;
            BiologyMark = biologyMark;
            Reward = reward;
        }

        public void ShowStudentInfo()
        {
            Console.WriteLine($"Student name {Name}, Studen group {Group}, Studentid {Id},MathMark {MathMark},PhysicalEducationMark {PhysicalEducationMark} BiologyMark {BiologyMark}");
            Console.WriteLine("Reward:" + Reward);
        }


    }
}
