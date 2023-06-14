using Home_SeleniumTests.Calc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_SeleniumTests.Tests
{

    /*  1.  В отдельном проекте создать класс Calculator,
     *  содержащий 4 метода: 
     *  сумма, разность, деление, умножение.

  * Optional: Написать тесты для домашней работы с
  * созданием треугольников(Triangle builder),
  * проверить тип созданного треугольника,
  * правильность подсчета площади,
  * дополнить тестами на свой усмотрение.
  
  2.  В том же проекте создать несколько тестовых классов, 
    по одному на каждый метод, протестировав наш калькулятор

  3.  В тестах использовать аннотации 
    и параметры Nunit.https://docs.nunit.org/articles/nunit/writing-tests/attributes/apartment.html

  Обязательные: SetUp, TearDown, TestCase Retry,
    Random, Values, Range, Description, Category
  {
          */
    [TestFixture]
    internal class Home_11_tests : BaseTestHome
    {

        [Test]
        [Category("Addition tests")]
        [Description("Possitive Test")]
        public void PossitiveAdd(
         [Values(1)] double operand1,
         [Values(2)] double operand2)
        {
            var expected = 3;
            var actual = calculator.Add(operand1, operand2);
            Assert.That(actual, Is.EqualTo(expected));
        }


        [Test, Retry(2)]
        [Category("Addition tests")]
        [Description("Random and soft tests")]
        public void RandomAddSoft(
         [Values(1, 2, 3)] double operand1, [Random(0, 4, 5)] double operand2)
        {
            var expected = 4;
            var actual = calculator.Add(operand1, operand2);

            ///simple wonna try soft
            Assert.Multiple(() =>
            {
                Assert.AreEqual(1, actual);
                Assert.AreEqual(2, actual);
                Assert.AreEqual(3, actual);
                Assert.AreEqual(4, actual);
                Assert.AreEqual(5, actual);
                Assert.That(actual, Is.EqualTo(expected));

            });
        }

        [Test]
        [Category("Sustraction tests")]
        [Description("Possitive Test")]
        public void PossitiveSubTest()
        {
            var operand1 = 100;
            var operand2 = 40;
            var actual = calculator.Subtraction(operand1, operand2);
            Assert.That(actual, Is.EqualTo(60));
            Console.WriteLine(actual);

            operand1 = 100;
            operand2 = -40;
            actual = calculator.Subtraction(operand1, operand2);
            Assert.That(actual, Is.EqualTo(140));
            Console.WriteLine(actual);

            var expected = -140;
            operand1 = -100;
            operand2 = 40;
            actual = calculator.Subtraction(operand1, operand2);
            Assert.That(actual, Is.EqualTo(expected));
            Console.WriteLine(actual);
        }


        [Test]
        [Category("Sustraction tests")]
        [Description("Random Test")]
        public void RandomSubTestSoft([Range(5, 7)] double operand1, [Random(0, 5, 2)] double operand2)
        {
            var actual = calculator.Subtraction(operand1, operand2);
            Console.WriteLine(actual);
            var expected = operand1 - operand2;

            Assert.Multiple(() =>
            {
                Assert.AreEqual(1, actual);
                Assert.AreEqual(2, actual);
                Assert.AreEqual(3, actual);
                Assert.AreEqual(4, actual);
                Assert.AreEqual(5, actual);
                Assert.That(actual, Is.EqualTo(expected));
            });
        }

        [Test]
        [Category("Division tests")]
        [Description("Possitive Test")]
        public void DivisionTest([Range(1, 4)] double operand1, [Random(0, 10, 2)] double operand2)
        {
            var actual = calculator.Division(operand1, operand2);
            Console.WriteLine(actual);
            var expected = operand1 / operand2;
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test, Retry(2)]
        [Category("Multiply tests")]
        [Description("Possitive Test")]
        public void MultyplayTest([Range(1, 3)] double operand1, [Random(0, 10, 4)] double operand2)
        {
            var actual = calculator.Multiply(operand1, operand2);
            Console.WriteLine(actual);
            var expected = operand1 * operand2;
            Assert.That(actual, Is.EqualTo(expected));
        }
    }

}




