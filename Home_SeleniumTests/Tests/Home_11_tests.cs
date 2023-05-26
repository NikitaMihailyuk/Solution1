using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_SeleniumTests.Tests
{

  /*  1.  В отдельном проекте создать класс Calculator, содержащий 4 метода: 
   *  сумма, разность, деление, умножение.

* Optional: Написать тесты для домашней работы с созданием треугольников(Triangle builder), проверить тип созданного треугольника, правильность подсчета площади, дополнить тестами на свой усмотрение.


2.  В том же проекте создать несколько тестовых классов, 
  по одному на каждый метод, протестировав наш калькулятор

3.  В тестах использовать аннотации 
  и параметры Nunit.https://docs.nunit.org/articles/nunit/writing-tests/attributes/apartment.html

Обязательные: SetUp, TearDown, TestCase Retry,
  Random, Values, Range, Description, Category
{
        */

    }
    public class Home_11_tests
    {
    [Test, Category("Smoke"), Description("Super test")]

    [TestFixture]
    [Category("AddTest")]
    [Random(0, 10, 10)]
    double operand1,
            [Random(0, 10, 10)] double operand2)
         [Values(1, 2, 3)]
    double operand1,
            [Random(0, 10, 5)] double operand2)
        Range
}
}
