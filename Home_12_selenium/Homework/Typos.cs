using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;



namespace Home_12_selenium
{
    /*
    Typos - Проверить соответствие параграфа орфографии
i.Локатор By.tagName(“p”) */

    internal class Typos : BaseTest
    {

        [Test]
        public void TyposTest()
        {
            string typoExpected = "Sometimes you'll see a typo, other times you won't";
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/typos");
            var typoText = driver.FindElements(By.TagName("p"))[1].Text;
            Console.WriteLine(typoText);
            Assert.That(typoText, Is.EqualTo(typoExpected));
        }

    }
}
