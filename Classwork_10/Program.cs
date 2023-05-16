using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork_10
{
    internal class Program
    {

        delegate void Message();
        delegate void PrintText(string t);
        public delegate int Operation(int i, int j);
        delegate int OperationGeneric <T> (T i, T j);

        static void Main(string[] args)
        {


            string date = "15/5/2023";

            Message message = delegate () //delegate bez ()
            {
                Console.WriteLine("Anon method" + date);
            };


            message = () => ///net parametrov kak vverh
            {
                Console.WriteLine("Anon method" + date);
                Console.WriteLine("Anon method" + date);
            };
            message();


            OperationGeneric<int> operationGeneric;
                       Operation operation;
            operation = Calculator.Add;
            operation += Calculator.Multiply;
            operation += Calculator.Substract;
            Console.WriteLine(operation(2, 6));

            operation =(x,y) => x+y; ///usloviya delegata int

            operationGeneric = Calculator.Add;
            Console.WriteLine(DoOperation(2, 6, delegate (int x, int y) { return x + y;}));
            Console.WriteLine(DoOperation(2, 6, (x, y) => x+y));
            operation += (x, y) => x - y;

        }

        public static int DoOperation(int x, int y, Operation operation)
        {
            return operation(x, y);
        }
        public static Operation SelectOperation(OperationType operation)
        {

            switch (operation)
            {
                case OperationType.Add: return Calculator.Add;
                case OperationType.Multiply: return Calculator.Multiply;
                case OperationType.Substract: return Calculator.Substract;
                default: return Calculator.Add;
            }
         
        }

        public enum OperationType
        {
            Add,
            Multiply,
            Substract
        }

        public static void Test1()
        {
            Message message; ///message?
            message = PrintHello;
            message();
            message = TextSender.PrintHelloRus;
            message();
            Console.ReadLine();
            PrintText printText;
            PrintText printText1;
            PrintText printText2;
            printText = TextSender.PrintTextForSent;
            printText("Text");
            //message()
            //ref
            //in
            //out
            printText += PrintTextMessage;
            printText += PrintTextMessage;
            printText -= PrintTextMessage;
            if (printText != null) printText("tedy");
            printText?.Invoke("tedy");
            printText1 = PrintTextMessage;
            printText2 = TextSender.PrintTextForSent;
            PrintText printTextFinal;
            printTextFinal = printText1 + printText2;
            printTextFinal("trtrt");

        }


        public static void PrintHello()
        {
            Console.WriteLine("Hello");

        }
        public static void PrintTextMessage(string message)
        {
            Console.WriteLine("/"+message+"123");
        }

    }

    internal class TextSender
    {
        public static void PrintHelloRus()
        {
            Console.WriteLine("Привет");
        }

        public static void PrintTextForSent(string message)
        {
            Console.WriteLine("///");
        }
    }

    public class Calculator 
    
    { 
       public static int Add(int x, int y)
       {
            return x + y;
       }
        public static int Substract(int x, int y)
        {
            return x - y;
        }
        public static int Multiply(int x, int y)
        {
            return x * y;
        }
    }

}
