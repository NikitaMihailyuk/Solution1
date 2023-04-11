using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork_5
{
    public class StudentsCreator
    {

        public Student[] CreateStudents()
        {
            Student[] arrayOfStudents = new Student[3];
            string[] names = { "alex", "Dmitri", "Marry" };
            Random rnd = new Random();

            for (int i = 0; i < arrayOfStudents.Length; i++)
            {
                int randMark = rnd.Next(1,10);
                arrayOfStudents[i] = new Student(names[i],"SuperGroup", randMark);
            }
            return arrayOfStudents;
        }
    }
}
