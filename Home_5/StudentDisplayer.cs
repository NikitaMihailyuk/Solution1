using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_5
{
    public class StudentDisplayer
    {
        public void DisplayStudents(Student[] arrayOfStudents)
        {
            Console.WriteLine();
            foreach (Student student in arrayOfStudents)
            {
                student.ShowStudentInfo();
            }
        }

        public void DisplayStudent(Student arrayOfStudent)
        {
            Student student = arrayOfStudent;
            Console.WriteLine();
            student.ShowStudentInfo();
        }

    }
}
