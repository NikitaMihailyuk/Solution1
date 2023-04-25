using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            try
            {
 
                int c = b / a;
                string a1 = null;
                bool k = a1.Contains("a");
                Console.WriteLine("some");
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.TargetSite);
                Console.WriteLine(ex.Source);
            }
       
            catch(NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.TargetSite);
                Console.WriteLine(ex.Source);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.TargetSite);
                Console.WriteLine(ex.Source);
            }
            finally
            {
                Console.WriteLine("block finaly");
            }

            try
            {
                Div(a, b);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("f1234");
            Console.ReadLine();
            try
            {
                Person person = new Person("123",10);
            }
            catch(PersonException ex)
            {
                Console.WriteLine(ex.InnerException);
            }
        }

        public static int Div(int a, int b)
        {
            int c = 0;
            try
            {
             c = b / a;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
                return c;  
        }
    }
}
