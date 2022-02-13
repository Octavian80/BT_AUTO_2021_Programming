using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using TestProject1.Pages;
using TestProject1.Tests;
using TestProject1.Utilities;

namespace TestProject1.Test.RegistrationTest
{
    class RegTest:BaseTest
    {
        string url = FrameworkConstants.GetUrl();

        private static IEnumerable<TestCaseData> GetCredentialsDataCsv()
        {
            foreach (var values in Utils.GetGenericData("TestData\\Registrationdata.csv"))
            {
                yield return new TestCaseData(values);
            }
        }

        [Test, TestCaseSource("GetCredentialsDataCsv")]


        //  [TestCase ("AAAAAAAA","XXXXXXXXX", "XXXXXXXXX","Iancu","Stefanescu","a@ro","111111111")]
        public void BasicRegistration(string user,string passw,string confpass,string firstName,string lastName,string email,string dateOfBirth)
        {
            driver.Navigate().GoToUrl(url + "registration");
            RegistrationPage rp = new RegistrationPage(driver);
            Assert.AreEqual("Registration", rp.CheckPage());
            rp.Registration(user,passw,confpass,firstName,lastName,email,dateOfBirth);

           
        }

        private static IEnumerable<TestCaseData> GetCredentialsDataCsv1()
        {
            foreach (var values in Utils.GetGenericData("TestData\\RegistrationError.csv"))
            {
                yield return new TestCaseData(values);
            }
        }

        [Test, TestCaseSource("GetCredentialsDataCsv1")]

        public void ErrorRegistration(string user, string passw, string confpass, string firstName, string lastName, string email, string dateOfBirth,string userError,string passerorr,string passConferror,string firstnamerorr,string lastnamerror,string emailerror)
        {
            driver.Navigate().GoToUrl(url + "registration");
            RegistrationPage rp = new RegistrationPage(driver);
            Assert.AreEqual("Registration", rp.CheckPage());
            rp.Registration(user, passw, confpass, firstName, lastName, email, dateOfBirth);
            Assert.AreEqual(userError, rp.UserError());
            Assert.AreEqual(passerorr, rp.PassError());
            Assert.AreEqual(passConferror, rp.PassConfError());
            Assert.AreEqual(firstnamerorr, rp.FirstNameError());
            Assert.AreEqual(lastnamerror, rp.LastNameErorr());
            Assert.AreEqual(emailerror, rp.emailError());

        }
    }
}
