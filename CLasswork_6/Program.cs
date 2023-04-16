using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLasswork_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  Console.WriteLine();
              ShowVariables("1234");
              ShowVariables("QWER", "QWEQR","WEQWR");


              Student student = new Student("Alex", "group");
              string name = student.Name;
              student.Showinfo();

              Person person = new Person(" 12e");
              person.Name = name;
              person.ShowInfo();

              Person person1 = new Student("324", "34324");

              person1.Name = name; //toka name

              person1.ShowInfo(); // v student coz ovveride

              Person person2 = new SpecialStudent("324", "34324","324");

              person1.ShowInfo(); // v special  coz ovveride and base

              Opera1(Operation.Devide);

            //  string description = Enumeration.GetEnumDescription(Operation.plus);

           */

            Mentor mentor = new Mentor("Mentorsname", Discipline.TestAutoation);
            Student1 student1 = new Student1("namestu", 10);
            Student1 student2 = new Student1("namestu2", 10);
            Student1[] students = { student1, student2 };
            Course course = new Course(" AUTOTOT", 100, students);
            ITschool tschool = new ITschool("TMS",mentor, course);

          tschool.ShowInfo();

            Console.ReadLine();

        }
        public void SpecialMethod(Person person2)
        {
           person2.ShowInfo();
        }

        public void ShowVariable( int[] a)
        {
            Console.WriteLine(a);
        }

        public static void ShowVariables(params string[] name)
        {
            foreach(string s in name)
            {
                Console.WriteLine(s);
            }
          
        }
        public static void Opera1(Operation i)
        {
            switch(i)
            {
                case Operation.plus: Console.WriteLine();
                    break; case Operation.minus: Console.WriteLine();
                    break;
            }
            
        }
         
        

    }
}
