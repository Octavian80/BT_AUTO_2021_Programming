using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject1.Pages
{
    class LoginPage:BasePage
    {
        const string authPageText = "text-muted"; 
        const string usernameLabel = "#login-form > div:nth-child(1) > label";
        const string usernameInput = "input-login-username";
        const string usernameError = "#login-form > div:nth-child(1) > div > div > div.text-left.invalid-feedback";
        const string passwordLabel = "#login-form > div.form-group.row.row-cols-lg-true > label";
        const string passwordInput = "input-login-password"; 
        const string passwordError = "#login-form > div.form-group.row.row-cols-lg-true > div > div > div.text-left.invalid-feedback";
        const string submitButton = "btn-primary"; 

        public LoginPage(IWebDriver driver) : base(driver)
        {
        }

        public string CheckPage()
        {
            var authPageEl = driver.FindElement(By.ClassName(authPageText));
            return authPageEl.Text;
        }

        public void Login(string user, string passw)
        {
            var usernameInputElement = driver.FindElement(By.Id(usernameInput));
            usernameInputElement.Clear();
            usernameInputElement.SendKeys(user);
            var passwordInputElement = driver.FindElement(By.Id(passwordInput));
            passwordInputElement.Clear();
            passwordInputElement.SendKeys(passw);
            var submitButtonElement = driver.FindElement(By.ClassName(submitButton));
            submitButtonElement.Submit();
        }

        public string UserError()
        {
            var userErrorPageEl = driver.FindElement(By.CssSelector(usernameError));
            return userErrorPageEl.Text;
        }

        public string PassError()
        {
            var passErrorPageEl = driver.FindElement(By.CssSelector(passwordError));
            return passErrorPageEl.Text;
        }
    }
}
