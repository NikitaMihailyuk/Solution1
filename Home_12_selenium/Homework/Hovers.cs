using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System.Runtime.Intrinsics.X86;
using OpenQA.Selenium.DevTools;

namespace Home_12_selenium
{

    /*
    Hovers - Сделать цепочку из действий: наведение на профиль,
проверка имени, клик по ссылке, проверка что нет 404 ошибки.
Повторить для каждого из профилей. Использовать класс Actions и
    */

    internal class Hovers : BaseTest
    {

        string errorString = "Not Found";
        string user1 = "name: user1";
        string user2 = "name: user2";
        string user3 = "name: user3";


        [Test]
        public void HoversTest()
        {
            Actions action = new Actions(driver);
            ReturnToHovers();
            ///Test 1 user
            var element2 = UserTextSelector(0);
            Assert.That(element2, Is.EqualTo(user1));
            var pageText = UserErrorSelector();
            /// Equal for continue tests
            Assert.That(pageText, Is.EqualTo(errorString));
            ///Test 2 user
            ReturnToHovers();
            element2 = UserTextSelector(1);
            Assert.That(element2, Is.EqualTo(user2));
            pageText = UserErrorSelector();
            Assert.That(pageText, Is.EqualTo(errorString));
            ///Test 3 user
            ReturnToHovers();
            element2 = UserTextSelector(2);
            Assert.That(element2, Is.EqualTo(user3));
            pageText = UserErrorSelector();
            Assert.That(pageText, Is.EqualTo(errorString));
        }

        public string UserTextSelector(int userNumber)
        {
            Actions action = new Actions(driver);
            var element = driver.FindElements(By.ClassName("figure"))[userNumber];
            action.MoveToElement(element).Perform();
            return driver.FindElements(By.TagName("h5"))[userNumber].Text;
        }
        public string UserErrorSelector()
        {
            driver.FindElements(By.PartialLinkText("View"))[0].Click();
            Console.WriteLine(driver.Url);
            return driver.FindElement(By.TagName("h1")).Text;
        }
        public void ReturnToHovers()
        {
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/hovers");
        }

    }
}
