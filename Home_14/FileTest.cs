using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Home_14
{
    [TestFixture]
    public class FileTest : BaseTest
    {
        [Test]
        public void Upload()
        {
            Browser.Instance.NavigateToUrl("http://the-internet.herokuapp.com/upload");
         //   Browser.Instance.Driver.FindElement(By.Id("file-upload")).SendKeys(DirectoryHelper.GetTestDataFolderPath() + "homework14.jpg");
            Browser.Instance.Driver.FindElement(By.Id("file-upload")).SendKeys(@"C:\Users\Никита\Source\Repos\NikitaMihailyuk\Solution1\Home_14\Core\homework14.jpg");
            var text = Browser.Instance.Driver.FindElement(By.Id("file-upload")).Text;
            text = Browser.Instance.Driver.FindElement(By.Id("file-upload")).GetAttribute("value");
            Console.WriteLine(text);
            Assert.That(text, Is.EqualTo("C:\\fakepath\\homework14.jpg"));

        }
    }
}
