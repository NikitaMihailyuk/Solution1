using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork_5
{
    internal class Program
    {
        ///классы и методы

        static void Main(string[] args)
        {
           StudentsCreator studentsCreator = new StudentsCreator();
           Student[] arrayOfStudents = studentsCreator.CreateStudents();
           StudentDisplayer studentDisplayer = new StudentDisplayer();
           studentDisplayer.DisplayStudents(arrayOfStudents);










            string userName = "Alex";
            int userAge = 10;
            int userid = 1;
            Class1 alex = new Class1(userName,userAge,userid);
            alex.SayYourName();
            alex.SayYourName("213445");

            int a = alex.age;

            userName = "Andrei";
            userAge = 21;
            userid = 2;

            Class1 andrei = new Class1(userName, userAge, userid);
            andrei.SayYourName();

            Console.WriteLine(andrei.age);

            // Class1 Mary = new Class1()
            //  {
            ///age = 1, id = 1
            //  };
            // Mary.SayYourName();
            andrei.KeepYourSecret(out string secondPart,out string firstSecret);
            Console.WriteLine(secondPart);
            Console.WriteLine(firstSecret);
            ///
            andrei.age = 1;





           andrei.age=DoSomething(class1); ?????


            Console.ReadLine();

        }


        public static void DoSomething(Class1 class1)
        {
            class1.age = class1.age + 10;

        }

    }
}
