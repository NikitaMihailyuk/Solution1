using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_12_selenium
{
    internal class AddRemoveTests : BaseTest
    {
        [Test]
        public void AddRemoveButton()
        {
            //var
            var expectedUrl = "https://the-internet.herokuapp.com/add_remove_elements/";
            driver.FindElement(By.LinkText("Add/Remove Elements")).Click();
            Assert.That(driver.Url, Is.EqualTo(expectedUrl));

            driver.FindElement(By.TagName("button")).Click();
            var addedButton = driver.FindElement(By.ClassName("added-manualy"));
            Assert.That(addedButton, Is.Not.Null);

            addedButton.Click();
            Assert.IsEmpty(driver.FindElements(By.ClassName("added-manualy")));
   
        }

        [Test]
        public void OpenGoogleWindow()
        {
            driver.Navigate().GoToUrl("Google.com");   
        }
    }
}
