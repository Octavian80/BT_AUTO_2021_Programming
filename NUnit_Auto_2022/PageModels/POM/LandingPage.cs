﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnit_Auto_2022.PageModels.POM
{
    public class LandingPage
    {
        const string authButtonSelector = "hidden-sm"; // class
        const string authPopupSelectro = "nav-stacked";// class
        const string registerAccLinkSelector = "ul > li:nth-child(2) > a"; //css 
        const string myCartSelector = "cart-count-withtext"; //class
        const string myCartAreaSelector = "cart-content";//class
        const string myCartButtonSelector = "div";//tagname
        const string searchBoxSelector = "search-box";// id
        const string searchButtonSelector = "btn btn-primary";//class
        const string checkPageSelector = "h1";

        IWebDriver driver;

        public LandingPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public string CheckPage()
        {
            return driver.FindElement(By.TagName(checkPageSelector)).Text;
        }

        public void LoginNavigate()
        {
            var authButtn = driver.FindElement(By.ClassName(authButtonSelector));
            authButtn.Click();
            var authArea = driver.FindElement(By.ClassName(authPopupSelectro));
            var registerAccElement = authArea.FindElement(By.CssSelector(registerAccLinkSelector));
            registerAccElement.Click();

        }
    }
}
