using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name");
            var user = Console.ReadLine();
            Console.WriteLine($"Hello,{user}");
            //anything();
            // task1();
            // task2();
            // task3();
            task4();
            var stoper = Console.ReadLine();
        }

        private static void task2()
        {
            Console.WriteLine("введите переменную");
            string numberStr = Console.ReadLine();
            int number = int.Parse(numberStr);
            if ((number > 5) && (number < 10))
            {
                Console.WriteLine("Bigger than 5 and less than 10");
            }
            else if (number == 7)
            {

                Console.WriteLine("number is 7");
            }
            else
            {
                Console.WriteLine("unknow number");
            }
        }

        private static void task3()
        {
            ///bank task  result + deposit + %
            ///
            Console.WriteLine("введите переменную");
            int deposit = int.Parse(Console.ReadLine());
            double result = deposit;

            if (result <= 0)
            {
                Console.WriteLine("fdfdf input");
                return;
            }

            if (deposit < 100 && deposit > 0)
            {
                result += result * 0.05;
            }
            else if (deposit >= 100 && deposit <= 200)
            {
                result += result * 0.07;
            }
            else if (deposit > 200 && deposit < 210)
            {
                result += result * 0.1;
            }
            double finalResult = result;
            Console.WriteLine(finalResult);


        }

        public static void task1()
        {
            double radius = Convert.ToDouble(Console.ReadLine());
            double height = Convert.ToDouble(Console.ReadLine());
            double pi = Math.PI;

            double volume = pi * Math.Pow(radius, 2) * height;
            double square = 2 * pi * radius * (radius + height);
            Console.WriteLine("Square" + Math.Round(square, 2));
            Console.WriteLine("Volume" + Math.Round(volume, 2));
            var stoper = Console.ReadLine();

        }

        public static void anything()
        {
            int t = 5, y = 5, u = 5;
            //t = +u = +y;

            byte a = 5;
            byte b = (byte)(a + 300);
            Console.WriteLine($"B={b}");

            byte height = 128;
            double height1 = 256.5;

            bool u1 = t == y;
            bool u2 = t <= y;
            bool u3 = t != y;

            bool u4 = (5 > 6) || (4 < 6);
            bool u5 = (5 > 6) && (4 < 6);
            //кусок из дз
            /*
            4214234
            2314
            */
            double pi = Math.PI;
            double piShort = Math.Round(pi, 2);
            decimal piDec = (decimal)pi;
            Console.WriteLine($"Pi short is: {piShort}");
            //Console.WriteLine("Pi short is" + piShort);
            Console.WriteLine($"Pi is: {pi}");
            //Cоздайте 3 строковые переменные 
            Console.Write("Hi");
            Console.Write("\n Alex");
            //Каретка
            Console.Write("Hi");
            Console.Write("\tAlex");

            //площадь круга
            string radius = Console.ReadLine();
            double radiusConverted = Convert.ToDouble(radius);
            double radiusConverted1 = Double.Parse(radius);
            double Ssquare = pi * Math.Pow(radiusConverted, 2);
            Console.WriteLine(Ssquare);
            // объем и площадь цилиндра V=pR2h
            //S=2piR(R+H)

        }

        private static void task4()
        {
            // число кратно 2 и 3

            Console.WriteLine("введите переменную");
            int number = int.Parse(Console.ReadLine());
            if (number % 2 == 0 && number % 3 == 0)
            {
                Console.WriteLine("number is divided 2 and 3");
            }
            else if (number % 2 == 0)
            {
                Console.WriteLine("2");
            }
            else if (number % 3 == 0)
            {
                Console.WriteLine("3");
            }
            else
            {
                Console.WriteLine("number is not divided 2 and 3");
            }


        }

    }

}
