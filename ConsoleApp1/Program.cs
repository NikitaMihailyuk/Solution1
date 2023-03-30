using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя пользователя");
            var user = Console.ReadLine();
            Console.WriteLine($"Hello,{user}");
            var stoper = Console.ReadLine();
        } 
    }
}
