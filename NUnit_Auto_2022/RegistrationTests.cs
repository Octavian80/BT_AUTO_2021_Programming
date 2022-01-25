using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnit_Auto_2022
{
    class RegistrationTests
    {
        IWebDriver driver ;
        const string protocol = "http";
        const string hostname = "86.121.249.150";
        const string port = "4999";
        const string path = "/#/registration";
        string url = protocol + "://" + hostname + ":" + port + path;

        [SetUp]

        public void SetUp()
        {
            driver = new ChromeDriver();

        }

        [TestCase("Otica","aaaaaaaaa", "aaaaaaaaa", "octavian","oros","orosromul@gmail.com","23111980","","","","","","")]
        [TestCase("Otica","aaaaaaaaa", "aaaaaa", "octavian","oros","orosromul@gmail.com","23111980","","","Passwords do not match!","","","")]
        [TestCase("Otica","aaaaaaaaa", "aaaaaaaaa", "o","oros","orosromul@gmail.com","23111980","","","", "Minimum of 2 characters is required!", "","")]
        [TestCase("Ot","aaaaaaaaa", "aaaaaaaaa", "octavian", "oros","orosromul@gmail.com","23111980", "Minimum of 4 characters is required!", "","","","","")]
        [TestCase("Otica", "aa", "aa", "octavian", "oros","orosromul@gmail.com","23111980", "","Minimum of 8 characters is required!", "","","","")]
        [TestCase("Otica", "aaaaaaaaa", "aaaaaaaaa", "octavian","o","orosromul@gmail.com","23111980","","", "","", "Minimum of 2 characters is required!", "")]
        [TestCase("Otica", "aaaaaaaaa", "aaaaaaaaa", "octavian","oros","or","23111980","","", "","", "", "Invalid email address!")]
        [TestCase("Otica", "aaaaaaaaa", "aaaaaaaaa", "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", "oros", "orosromul@gmail.com", "23111980","","","","Maximum of 35 characters allowed!", "","")]
        [TestCase("Otica", "aaaaaaaaa", "aaaaaaaaa", "55555", "oros", "orosromul@gmail.com", "23111980","","","", "2 to 35 letters and '-' only!", "","")]

        public void Test(string user, string pass,string passconf,string name,string lname,string emailinput,string date,string userError, string passError, string confpasError,string firstErorr,string lastErorr,string emailErorr  )
        {
            driver.Navigate().GoToUrl(url);
            var username = driver.FindElement(By.Id("input-username"));
            var password = driver.FindElement(By.Id("input-password"));
            var passwordconfirmation = driver.FindElement(By.Id("input-password-confirm"));
            var titlemr = driver.FindElement(By.CssSelector("#registration-form > div:nth-child(6) > div > div:nth-child(1) > label"));
            var titlems = driver.FindElement(By.CssSelector("#registration-form > div:nth-child(6) > div > div:nth-child(2) > input"));
            var firstname = driver.FindElement(By.Id("input-first-name"));
            var lastname = driver.FindElement(By.Id("input-last-name"));
            var email = driver.FindElement(By.Id("input-email"));
            var dateofbirth = driver.FindElement(By.Id("input-dob"));
           // Select nationality = new Select (driver.FindElement(By.Id("input-nationality")));
            var terms = driver.FindElement(By.CssSelector("#registration-form > div:nth-child(12) > div.text-left.col-lg > div > label"));
            var submit = driver.FindElement(By.CssSelector("#registration-form > div:nth-child(13) > div.text-left.col-lg > button"));
            var usernameError = driver.FindElement(By.CssSelector("#registration-form > div:nth-child(2) > div > div > div.text-left.invalid-feedback"));
            var passwordError = driver.FindElement(By.CssSelector("#registration-form > div:nth-child(3) > div > div > div.text-left.invalid-feedback"));
            var confirmpassError = driver.FindElement(By.CssSelector("#registration-form > div:nth-child(4) > div > div > div.text-left.invalid-feedback"));
            var firstnameErorr = driver.FindElement(By.CssSelector("#registration-form > div:nth-child(7) > div > div > div.text-left.invalid-feedback"));
            var lastnameErorr = driver.FindElement(By.CssSelector("#registration-form > div:nth-child(8) > div > div > div.text-left.invalid-feedback"));
            var emErorr = driver.FindElement(By.CssSelector("#registration-form > div:nth-child(9) > div > div > div.text-left.invalid-feedback"));




            username.Clear();
            username.SendKeys(user);

            password.Clear();
            password.SendKeys(pass);

            passwordconfirmation.Clear();
            passwordconfirmation.SendKeys(passconf);

            titlemr.Click();
            titlems.Click();

            firstname.Clear();
            firstname.SendKeys(name);

            lastname.Clear();
            lastname.SendKeys(lname);

            email.Clear();
            email.SendKeys(emailinput);

            dateofbirth.Clear();
            dateofbirth.SendKeys(date);

            terms.Click();

            submit.Submit();

            Assert.AreEqual(userError, usernameError.Text);
            Assert.AreEqual(passError, passwordError.Text);
            Assert.AreEqual(confpasError, confirmpassError.Text);
            Assert.AreEqual(firstErorr, firstnameErorr.Text);
            Assert.AreEqual(lastErorr, lastnameErorr.Text);
            Assert.AreEqual(emailErorr, emErorr.Text);





         
        }







       [TearDown]

       public void TearDomn()
        {
            driver.Quit();
        }


    }
}
