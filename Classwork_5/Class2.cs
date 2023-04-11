using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork_5
{
    public class StudentDisplayer
    {
        public void DisplayStudents(Student[] arrayOfStudents)
        {
            Console.WriteLine();
            foreach (Student student in arrayOfStudents)
            {
                student.ToString();
            }
        }
       
    }
}
