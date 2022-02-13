using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using TestProject1.Pages;
using TestProject1.Utilities;

namespace TestProject1.Tests
{
    class LoginTest:BaseTest
    {
        string url = FrameworkConstants.GetUrl();

        

        private static IEnumerable<TestCaseData> GetCredentialsDataCsv()
        {
            foreach (var values in Utils.GetGenericData("TestData\\Datelogin.csv"))
            {
                yield return new TestCaseData(values);
            }
        }

        [Test, TestCaseSource("GetCredentialsDataCsv")]

        public void BasicAuth(string username, string password)
        {
            driver.Navigate().GoToUrl(url + "login");
            LoginPage lp = new LoginPage(driver);
            Assert.AreEqual("Authentication", lp.CheckPage());
            lp.Login(username, password);
        }
        private static IEnumerable<TestCaseData> GetCredentialsDataCsv1()
        {
            foreach (var values in Utils.GetGenericData("TestData\\Datelogineroare.csv"))
            {
                yield return new TestCaseData(values);
            }
        }
        //   [TestCase("","","Username is required!","Password is required!")]
        //   [TestCase("user1","","","Password is required!")]
        //  [TestCase("","pass1","Username is required!","")]

        [Test, TestCaseSource("GetCredentialsDataCsv1")]

        public void ErrorAuth(string username, string password,string userErorrmessage,string passErrormessage)
        {
            driver.Navigate().GoToUrl(url + "login");
            LoginPage lp = new LoginPage(driver);
            Assert.AreEqual("Authentication", lp.CheckPage());
            lp.Login(username, password);
            Assert.AreEqual(userErorrmessage, lp.UserError());
            Assert.AreEqual(passErrormessage, lp.PassError());
        }



    }



}
