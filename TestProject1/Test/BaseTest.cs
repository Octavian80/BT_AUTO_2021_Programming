using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using TestProject1.Utilities;

namespace TestProject1.Tests
{
   class BaseTest
    {
        public IWebDriver driver;

        [SetUp]

        public void Setup()
        {
            //instatiate the browser using the Browser Factory class created in Utilities
            driver = Browser.GetDriver();
        }

        [TearDown]

        public void Teardowmn()
        {
            driver.Quit();
        }
    }
}
