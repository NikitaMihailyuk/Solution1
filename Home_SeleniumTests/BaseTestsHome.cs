using Home_SeleniumTests.Calc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_SeleniumTests
{
    [TestFixture]
    public class BaseTestHome
    { 

        public Calculator calculator;

        [SetUp]
        public void SetUp()
        {
            Console.WriteLine("---- Setup");
            calculator = new Calculator();
        }

        [TearDown]
        public void TearDown()
        {
            Console.WriteLine("---- TearDown");
        }
    }
}
