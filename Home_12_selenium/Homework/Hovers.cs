using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;


namespace Home_12_selenium
{

    /*
    Hovers - Сделать цепочку из действий: наведение на профиль,
проверка имени, клик по ссылке, проверка что нет 404 ошибки.
Повторить для каждого из профилей. Использовать класс Actions и
    */

    internal class Hovers : BaseTest
    {

        [Test]
        public void HoversTest()
        {
            string errorString = "Not Found";
            string user1 = "name: user1";
            string user2 = "name: user2";
            string user3 = "name: user3";

            Actions action = new Actions(driver);
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/hovers");

            ///Test 1 user
            var element = driver.FindElements(By.ClassName("figure"))[0];
            action.MoveToElement(element).Perform();
            var element2 = driver.FindElements(By.TagName("h5"))[0].Text;
            Assert.That(element2, Is.EqualTo(user1));
            driver.FindElements(By.PartialLinkText("View"))[0].Click();
            var pageText = driver.FindElement(By.TagName("h1")).Text;
            /// Equal for continue tests
            Assert.That(pageText, Is.EqualTo(errorString));


            ///Test 2 user
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/hovers");
            element = driver.FindElements(By.ClassName("figure"))[1];
            action.MoveToElement(element).Perform();

            element2 = driver.FindElements(By.TagName("h5"))[1].Text;
            Assert.That(element2, Is.EqualTo(user2));

            driver.FindElements(By.PartialLinkText("View"))[0].Click();
            pageText = driver.FindElement(By.TagName("h1")).Text;
            Assert.That(pageText, Is.EqualTo(errorString));

            ///Test 3 user

            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/hovers");
            element = driver.FindElements(By.ClassName("figure"))[2];
            action.MoveToElement(element).Perform();
            element2 = driver.FindElements(By.TagName("h5"))[2].Text;
            Assert.That(element2, Is.EqualTo(user3));

            driver.FindElements(By.PartialLinkText("View"))[0].Click();
            pageText = driver.FindElement(By.TagName("h1")).Text;
            Assert.That(pageText, Is.EqualTo(errorString));
        }
    }
}
