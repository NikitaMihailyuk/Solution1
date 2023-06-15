﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Home_selenium13.Core;


namespace Home_selenium13.SwagLabs.PageObject
{
    internal abstract class BasePage 
    {
        protected IWebDriver driver;

        public BasePage(IWebDriver webDriver)
        {
            driver = webDriver;
        }

        public abstract BasePage OpenPage();
    }
}
