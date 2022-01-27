﻿using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnit_Auto_2022
{
    class AuthenticationTests
    {
        IWebDriver driver;
        const string protocol = "http";
        const string hostname = "86.121.249.150";
        const string port = "4999";
        const string path = "/#/";

        string url = protocol + "://" + hostname + ":"+port+path;

        [SetUp]
        public void Setup()
        {
            //Chrome Options 
            var options = new ChromeOptions();
           // options.AddArgument("--start-maximized");
           // options.AddArgument("headless");
            options.AddArgument("ignore-certificate-errors");

            var proxy = new Proxy();
            proxy.HttpProxy = "127.0.0.1:8080";
            proxy.IsAutoDetect = false;
           // options.Proxy = proxy;
            //options.AddExtension("C:\\Users\\Octavian\\Downloads\\extension_4_42_0_0.crx");


            //firefox options 
            var firefoxOptions = new FirefoxOptions();

            string[] optionList =
            {
            //"--headless",
            "--ignore-certificate-errors",
            "--no-sanbox",
            "--disable-gpu",

            };

            firefoxOptions.AddArguments(optionList);
            FirefoxProfile fProfile = new FirefoxProfile();
            fProfile.AddExtension("C:\\Users\\Octavian\\Downloads\\metamask-10.8.1-an+fx.xpi");
            firefoxOptions.Profile = fProfile;

            //Edge options

            var edgeOptions = new EdgeOptions();
            // edgeOptions.AddExtension("C:\\Users\\Octavian\\Downloads\\metamask-10.8.1-an+fx.xpi");
            edgeOptions.AddArguments("args", "['start-maximized']");

            driver = new ChromeDriver(options);
            //driver = new FirefoxDriver(firefoxOptions);
           // driver = new EdgeDriver(edgeOptions);
            driver.Manage().Window.Maximize();


        }
        [TestCase("dinosaur","dinosaurpassword","","")]
        [TestCase("dinosaur","","", "Password is required!")]
        [TestCase("","", "Username is required!", "Password is required!")]
        [TestCase("", "dinopass", "Username is required!", "")]

        public void Test01(string user , string pass,string userErr ,string passErr)
        {
            Console.WriteLine(url);
            driver.Navigate().GoToUrl(url);
             
            var pageText = driver.FindElement(By.CssSelector("#root > div > div.content > div > div:nth-child(1) > div > div > h1 > small"));
            Assert.AreEqual("Home",pageText.Text);

            var loginLink = driver.FindElement(By.CssSelector("#root > div > div.sidebar > a:nth-child(2)"));
            loginLink.Click();
            Console.WriteLine(loginLink.GetAttribute("href"));

            pageText = driver.FindElement(By.CssSelector("#root > div > div.content > div > div:nth-child(1) > div > div > h1 > small"));
            Assert.AreEqual("Authentication", pageText.Text);

            var username = driver.FindElement(By.Id("input-login-username"));
            var password = driver.FindElement(By.Id("input-login-password"));
            var submit = driver.FindElement(By.CssSelector("#login-form > div:nth-child(3) > div.text-left.col-lg > button"));
            
            var usernameErorr = driver.FindElement(By.CssSelector("#login-form > div:nth-child(1) > div > div > div.text-left.invalid-feedback"));
            var passwordError = driver.FindElement(By.CssSelector("#login-form > div.form-group.row.row-cols-lg-true > div > div > div.text-left.invalid-feedback"));
            
            username.Clear();
            username.SendKeys(user);
            password.Clear();
            password.SendKeys(pass);

            submit.Submit();

            Assert.AreEqual(userErr, usernameErorr.Text);
            Assert.AreEqual(passErr, passwordError.Text);

        }
        // implicit wait test
        [Test]
        public void Test02()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            string url = protocol + "://" + hostname + ":8081/lazy.html";
            driver.Navigate().GoToUrl(url);

            var button1 = driver.FindElement(By.Id("btn1"));
            button1.Click();

        }

        [Test]

        public void Test03()
        {
            string url = protocol + "://" + hostname + ":8081/lazy.html";
            driver.Navigate().GoToUrl(url);

            // var wait = new WebDriverWait(driver,TimeSpan.FromSeconds(20));

            // var button1 = driver.FindElement(By.Id("btn1"));
            var button1 = Utils.WaitForElement(driver, 20, By.Id("btn1"));
            button1.Click();

        }

        [Test]

        public void Test04()
        {
            string url = protocol + "://" + hostname + ":8081/lazy.html";
            driver.Navigate().GoToUrl(url);

            // var wait = new WebDriverWait(driver,TimeSpan.FromSeconds(20));

            // var button1 = driver.FindElement(By.Id("btn1"));
            var button2 = Utils.WaitForElement(driver, 20, By.Id("btn2"));
            button2.Click();

            for (int i = 0; i < 100 ; i++)
            {
                button2.Click();
            }

        }

        [Test]

        public void Test05()
        {
            string url = protocol + "://" + hostname + ":8081/lazy.html";
            driver.Navigate().GoToUrl(url);

            var element = Utils.WaitForFluentElement(driver, 20, By.Id("btn2"));
            element.Click();
        }


        [Test]
        public void Test06()
        {

            driver.Navigate().GoToUrl("https://magazinulcolectionarului.ro/");

            var cookies = driver.Manage().Cookies;
            Console.WriteLine("The site contains{0} cookies", cookies.AllCookies.Count);
            Utils.PrintCookies(cookies);

            Cookie myCookie = new Cookie("mycookie", "vine");
            cookies.AddCookie(myCookie);
            Utils.PrintCookies(cookies);
            cookies.DeleteAllCookies();
            Console.WriteLine("The site contains{0} cookies", cookies.AllCookies.Count);



            Utils.TakeScreenshotWithDate(driver, "C://Temp", "screenshot", ScreenshotImageFormat.Png);
        }

        [Test]
        public void Test07()
        {
            driver.Navigate().GoToUrl("http://86.121.249.150:4999/#/alert");
            var alertButton = driver.FindElement(By.Id("alert-trigger"));
            var confirmButton = driver.FindElement(By.Id("confirm-trigger"));
            var promptButton = driver.FindElement(By.Id("prompt-trigger"));

            alertButton.Click();
            IAlert alert = driver.SwitchTo().Alert();
            Console.WriteLine(alert.Text);
            alert.Accept();

            confirmButton.Click();
            alert = driver.SwitchTo().Alert();
            Console.WriteLine(alert.Text);
            alert.Dismiss();

            promptButton.Click();
            alert = driver.SwitchTo().Alert();
            Console.WriteLine(alert.Text);
            alert.SendKeys("alex");
            alert.Accept();
        }

        [Test]

        public void Test08()
        {
            driver.Navigate().GoToUrl(url + "hover");
            // var hoverButton = driver.FindElement(By.CssSelector("#root > div > div.content > div > div.container-table.text-center.container > div > button"));
            var hoverButton = driver.FindElement(By.ClassName("btn-outline-info"));
            Actions actions = new Actions(driver);
            actions.MoveToElement(hoverButton).Build().Perform();
            

            var catSelect= driver.FindElement(By.Id("Cat"));
            catSelect.Click();

            var resultText = driver.FindElement(By.Id("result")).Text;

            Assert.AreEqual("You last clicked the Cat", resultText);

            var allItems = driver.FindElements(By.ClassName("clickable"));
            foreach(var item in allItems)
            {
                item.Click();
                var text = item.Text;
                var resultTxt = driver.FindElement(By.Id("result")).Text;
                Assert.AreEqual(String.Format("You last clicked the {0}", text), resultTxt);
            }
             

              
        }

        [Test]

        public void Test09()
        {
            driver.Navigate().GoToUrl(url+"stale");
            
            // threating a stale element :find the element before every interaction
            for ( int i =0; i<100; i++)
            {
                var button = driver.FindElement(By.Id("stale-button"));
                button.Click();
            }

            Utils.ExecuteJsScript(driver, "return document.title");

        }

        [Test]

        public void Test10()
        {
            driver.Navigate().GoToUrl(url);
            /*var body = driver.FindElement(By.TagName("body"));
            body.SendKeys(Keys.Control);
            body.SendKeys("t");*/

            foreach( var handle in driver.WindowHandles)
            {
                driver.SwitchTo().Window(handle);
                Console.WriteLine(handle);
            }
        }

        [Test]

        public void Test11()
        {
            driver.Navigate().GoToUrl("https://www.vexio.ro/info/despre-noi/contact/");

            var iframe = driver.FindElement(By.TagName("iframe"));

            driver.SwitchTo().Frame(iframe);
        }




        [TearDown]

        public void TearDown ()
        {
            driver.Quit();
        }
    }
}
