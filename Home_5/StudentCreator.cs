using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Home_5
{
    public class StudentCreator
    {
        Random rnd = new Random();
        public int idStd = 0;
        public Student[] CreateStudents1(string groupMark)
        {
            Student[] arrayOfStudents = new Student[5];
            string[] studentArray = new string[5];
            string[] names = { "alex", "Dmitri", "Marry", "Nikita", "John" };
            string[] names2 = { "alex2", "Dmitri2", "Marry2", "Nikita2", "John2" };
            string[] names3 = { "alex3", "Dmitri3", "Marry3", "Nikita3", "John3" };

            switch (groupMark)
            {
                case "Group a":
                    studentArray = names;
                    break;
                case "Group b":
                    studentArray = names2;
                    break;
                default:
                    studentArray = names3;
                    break;
            }
 

            for (int i = 0; i < studentArray.Length; i++)
            {
                int randMark = rnd.Next(1, 10);
                int randMark2 = rnd.Next(1, 10);
                int randMark3 = rnd.Next(1, 10);
                int reward = 0;
                arrayOfStudents[i] = new Student(studentArray[i], groupMark, ++idStd, randMark, randMark2, randMark3, reward);
            }
            return arrayOfStudents;
        }
    }
}
