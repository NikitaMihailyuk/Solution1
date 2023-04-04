using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();
            Task4();
            Console.ReadLine();
        }

        private static void Task1()
        {
            /*
            Задание 1

    Напишите программу - консольный калькулятор.
    Создайте две переменные с именами operand1 и operand2.
    Задайте переменным некоторые произвольные значения.
    Предложите пользователю ввести знак арифметической операции.
    Примите значение, введенное пользователем, и поместите его в строковую переменную sign.
    Для организации выбора алгоритма вычислительного процесса, используйте переключатель switch.
    Выведите на экран результат выполнения арифметической операции.
    **В случае использования операции деления, организуйте проверку попытки деления на ноль.
    И если таковая имеется, то отмените выполнение арифметической операции и уведомите об ошибке пользователя. 
     */
            Console.WriteLine("Input number for operand1");

            bool numberCheck = double.TryParse(Console.ReadLine(), out double operand1);
            if (numberCheck == false)
            {
                Console.WriteLine("incorrected operand type was entered");
                return;
            }
            Console.WriteLine("Input number for operand2");
            bool numberCheck2 = double.TryParse(Console.ReadLine(), out double operand2);
            if (numberCheck2 == false)
            {
                Console.WriteLine("incorrected operand type was entered");
                return;
            }
            Console.WriteLine("Input one operation for operand2\n*\n+\n-\n/\n");
            string Sign = Console.ReadLine();
            switch (Sign)
            {
                case "*":
                    double result = operand1 * operand2;
                    Console.WriteLine($"{operand1} * {operand2} = " + result);
                    break;
                case "+":
                    result = operand1 + operand2;
                    Console.WriteLine($"{operand1} + {operand2} = " + result);
                    break;
                case "-":
                    result = operand1 - operand2;
                    Console.WriteLine($"{operand1} - {operand2} = " + result);
                    break;
                case "/":
                    if (operand2 == 0)
                    {
                        Console.WriteLine("operand2 is 0, Error");
                        return;
                    }
                    result = operand1 / operand2;
                    Console.WriteLine($"{operand1} / {operand2} = " + result);
                    break;
                default:
                    Console.WriteLine("it's not the operation");
                    break;

            }

        }

        private static void Task2()
        {
            /*
     Задание 2

    Напишите программу определения, попадает ли указанное пользователем число от 0 до 100 в числовой промежуток [0 - 14] [15 - 35] [36 - 50][50 - 100].
    Если да, то укажите, в какой именно промежуток.
    Если пользователь указывает число, не входящее ни в один из имеющихся числовых промежутков, то выводится соответствующее сообщение.
                 */

            Console.WriteLine("enter a number to determine number gap ");

            bool numberCheck = double.TryParse(Console.ReadLine(), out double number);
            if (numberCheck == false)
            {
                Console.WriteLine("number is not inputed,error");
                return;
            }
            if (number > 0 && number <= 14)
            {
                Console.WriteLine("Gap is [0-14]");
            }
            else if (number > 14 && number <= 35)

            {
                Console.WriteLine("Gap is [15-35]");

            }
            else if (number > 35 && number <= 50)
            {
                Console.WriteLine("Gap is [36-50]");
            }
            else if (number > 49 && number <= 100)
            {
                Console.WriteLine("Gap is [50-100]");
            }
            else
            {
                Console.WriteLine("number is not in gap: " + number);
            }

        }

        private static void Task3()
        {
            Console.WriteLine("For translate in english input word in Russion on terminal");

            /*
               Задание 3

            Напишите программу русско-английский переводчик.
            Программа знает 10 слов о погоде.
            Требуется, чтобы пользователь вводил слово на русском языке, а программа давала ему перевод этого слова на английском языке.
            Если пользователь ввел слово, для которого отсутствует перевод, то следует вывести сообщение, что такого слова нет.
                         */
            string word1 = (Console.ReadLine());
            string wordR = word1.ToLower();

            if (wordR == "погода")
            {
                Console.WriteLine(wordR + " - wether");
            }
            else if (wordR == "cолнечно")
            {
                Console.WriteLine(wordR + " -  sunny");
            }
            else if (wordR == "облачно")
            {
                Console.WriteLine(wordR + " -  cloudy");
            }
            else if (wordR == "дождливо")
            {
                Console.WriteLine(wordR + " - rainy");
            }
            else if (wordR == "ветрено")
            {
                Console.WriteLine(wordR + " -  windy");
            }
            else if (wordR == "туманно")
            {
                Console.WriteLine(wordR + " - foggy");
            }
            else if (wordR == "холодно")
            {
                Console.WriteLine(wordR + " - Cold");
            }
            else if (wordR == "тепло")
            {
                Console.WriteLine(wordR + " - warm");
            }
            else if (wordR == "прохладно")
            {
                Console.WriteLine(wordR + " - chilly");
            }
            else if (wordR == "жарко")
            {
                Console.WriteLine(wordR + " - hot");
            }
            else
            {
                Console.WriteLine(wordR + " that word is not in dictionary");
            }
        }

        private static void Task4()
        {
            /*
Задание 4

Напишите программу, которая будет выполнять проверку чисел на четность.
             */

            Console.WriteLine("enter a number to determine parity");

            bool numberCheck = decimal.TryParse(Console.ReadLine(), out decimal number);
            if (numberCheck == false)
            {
                Console.WriteLine("incorrected operand type was entered");
                return;
            }
            if (number <= 0)
            {
                Console.WriteLine("Number must be possitive and not 0");
            }
            else if (number % 2 == 0)

            {
                var n1 = number % 2;
                Console.WriteLine("n1=" + n1);
                Console.WriteLine("number is parity " + number);

            }
            else if (number % 2 != 0)
            {
                var n1 = number % 2;
                Console.WriteLine("n1=" + n1);
                Console.WriteLine("number is  not parity " + number);
            }
            else
            {
                Console.WriteLine("incorrect number");
            }

        }

    }
}

