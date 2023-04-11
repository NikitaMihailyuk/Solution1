using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classwork_5;

namespace Classwork5_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age=1;
            Class1 class1 = new Class1("123",2,2);
            class1.KeepYourSecret(out string secondSecretPart, out string firstSecret);

        }
    }
}
