using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Classwork_5
{
      public class Class1
    {
        public int age;
        public string name;
        public int id;
        int a = 5;
        int b = 10;

   //  public Class1(string username, int userage, int userid)
     //  {
    //    name = username;
    //    id = userid;
    //    age = userage;
//}
    //    public Class1(string name, int age, int id)
    //    {
    //        this.name = name;
    //        this.id = id;
    //        this.age = age;
     //   }

 
        public Class1(string name)
        {
            this.name = name;
        }

        public Class1(string name, int age, int id) : this(name)
        {
            this.id = id;
            this.age = age;
        }
        public int Age
        {
            get { return age; }
            set { if (age < 0) age = 0; age = value;}
        }

        public int Age { get; set; } = 10;

        public void KeepYourSecret(out string secondSecretPart, out string firstSecret)
        {
            string firstSecretPart = "";
            string secondPart = "";
            secondSecretPart = secondPart;
            firstSecret = "";
        }

        public void SayYourName()
        {
            Console.WriteLine("My name is" + name);
            Console.WriteLine(age);
            string secondName = "Nest";
        }
        public void SayYourName(string name2)
        {
            Console.WriteLine("My name is" + name);
            Console.WriteLine(age);
            string secondName = "Nest";
        }

        string SayYourName2(string secret = "Secret")
        {
            Console.WriteLine(Class1.age);
            Console.WriteLine("My name is" + name);
            Console.WriteLine(secret);
            string secondName = "Nest";
            int newA = Task2(ref a);
            return secondName;

        }

        string SayYourName23(int a, int b, string secret = "Secret")
        {
            Console.WriteLine("My name is" + name);
            Console.WriteLine(secret);
            string secondName = "Nest";
            return secondName;

        }
         public static int Task(int a)
        {
            a = a + 5;
            return a;
        }
        public static int Task2(ref int a)
        {
            a = a + 5;
            return a;
        }

    }
}
