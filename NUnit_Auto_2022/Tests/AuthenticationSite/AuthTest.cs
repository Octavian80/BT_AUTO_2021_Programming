using NUnit.Framework;
using NUnit_Auto_2022.PageModels.POM;
using NUnit_Auto_2022.PageModels.PageFactory;
using NUnit_Auto_2022.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace NUnit_Auto_2022.Tests
{
    class AuthTest:BaseTest
    {
        

        string url = FrameworkConstants.GetUrl();

        private static IEnumerable<TestCaseData> GetCredentialsData()
        {
            yield return new TestCaseData("user1", "pass1");
            yield return new TestCaseData("user2", "pass2");
            yield return new TestCaseData("user3", "pass3");
            yield return new TestCaseData("user4", "pass4");
        }

        private static IEnumerable<TestCaseData> GetCredentialsDataCsv()
        {
            string path = "TestData\\credentials.csv";
            using (var reader = new StreamReader(path))
            {
                var index = 0;
                while (!reader.EndOfStream)
                {
                    var lines = reader.ReadLine();
                    var values = lines.Split(",");
                    if(index > 0)
                    {
                        yield return new TestCaseData(values[0], values[1]);
                    }

                    index++;
                }
            }
        }
        private static IEnumerable<TestCaseData> GetCredentialsDataCsv2()
        {
            foreach (var values in Utils.GetGenericData("TestData\\credentials.csv"))
            {
                yield return new TestCaseData(values);
            }
        }

        

        [Test,TestCaseSource("GetCredentialsDataCsv2")]
        
        public void BasicAuth(string username ,string password)
        {
            driver.Navigate().GoToUrl(url+"login");
            PageModels.POM.LoginPage lp = new PageModels.POM.LoginPage(driver);
            Assert.AreEqual("Authentication", lp.CheckPage());
            lp.Login(username,password);
        }

        private static string[] GetUsername = new string[]
        {
            "user1","user2","user3","user4"
        };

        private static string[] GetPassword = new string[]
        {
            "pass1","pass2","pass3","pass4"
        };

        //Test auth with Page factory

        [Test]

        public void BasicAuthpf([ValueSource("GetUsername")]string username , [ValueSource("GetPassword")] string password)
        {
            driver.Navigate().GoToUrl(url + "login");
            PageModels.PageFactory.LoginPage lp = new PageModels.PageFactory.LoginPage(driver);
            Assert.AreEqual("Authentication", lp.CheckPage());
            lp.Login(username,password);

            
        }



        
    }
}
