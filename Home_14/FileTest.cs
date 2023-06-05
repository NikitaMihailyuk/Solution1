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
            Browser.Instance.Driver.FindElement(By.Id("file-upload")).SendKeys(DirectoryHelper.GetTestDataFolderPath() + "HomeWork.docx");

            var text = Browser.Instance.Driver.FindElement(By.Id("file-upload")).Text;
            text = Browser.Instance.Driver.FindElement(By.Id("file-upload")).GetAttribute("value");


        }
    }
}
