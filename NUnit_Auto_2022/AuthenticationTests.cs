using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnit_Auto_2022
{
    class AuthenticationTests
    {
        IWebDriver driver;
        const string protocol = "http";
        const string hostname = "86.121.149.150";
        const string port = "4999";
        const string path = "/#/login";

        string url = protocol + "://" + hostname + port+path;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            

        }
        [Test]

        public void Test01()
        {
            driver.Navigate().GoToUrl(url);

            var username = driver.FindElement(By.Id("input-login-username"));
            var password = driver.FindElement(By.Id("input-login-password"));
            var submit = driver.FindElement(By.CssSelector("#login-form> div:nth-child(3)"));

            username.Clear();
            username.SendKeys("alex");

            username.Clear();
            username.SendKeys("alex");

        }

        [TearDown]

        public void TearDown ()
        {
            driver.Quit();
        }
    }
}
