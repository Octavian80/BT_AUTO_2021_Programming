using NUnit.Framework;
using NUnit_Auto_2022.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnit_Auto_2022.Tests
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
