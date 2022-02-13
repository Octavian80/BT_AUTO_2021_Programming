using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject1.Pages
{
    class RegistrationPage:BasePage
    {
        const string regPageText = "text-muted";
        const string usernameInput = "input-username";
        const string passwordInput = "input-password";
        const string passwordconfInput = "input-password-confirm";
        const string titleMr = "#registration-form > div:nth-child(6) > div > div:nth-child(1) > label";
        const string titleMs = "#registration-form > div:nth-child(6) > div > div:nth-child(2) > input";
        const string firstNameInput ="input-first-name";
        const string lastNameInput ="input-last-name";
        const string emailInput = "input-email";
        const string dateOfBirthInput ="input-dob";
        // Select nationality = new Select (driver.FindElement(By.Id("input-nationality")));
        const string terms ="terms";
        const string submit = "#registration-form > div:nth-child(13) > div.text-left.col-lg > button";
        const string userNameError ="#registration-form > div:nth-child(2) > div > div > div.text-left.invalid-feedback";
        const string passwordError ="#registration-form > div:nth-child(3) > div > div > div.text-left.invalid-feedback";
        const string confirmPassError ="#registration-form > div:nth-child(4) > div > div > div.text-left.invalid-feedback";
        const string firstNameErorr ="#registration-form > div:nth-child(7) > div > div > div.text-left.invalid-feedback";
        const string lastNameErorr ="#registration-form > div:nth-child(8) > div > div > div.text-left.invalid-feedback";
        const string emErorr ="#registration-form > div:nth-child(9) > div > div > div.text-left.invalid-feedback";

        public RegistrationPage(IWebDriver driver) : base(driver)
        {
        }

        public string CheckPage()
        {
            var regPageEl = driver.FindElement(By.ClassName(regPageText));
            return regPageEl.Text;
        }

        public void Registration(string user, string passw, string confpass,string firstName,string lastName,string email,string dateOfBirth)
        {
            var usernameInputElement = driver.FindElement(By.Id(usernameInput));
            usernameInputElement.Clear();
            usernameInputElement.SendKeys(user);
            var passwordInputElement = driver.FindElement(By.Id(passwordInput));
            passwordInputElement.Clear();
            passwordInputElement.SendKeys(passw);
            var passwordconfInputElement = driver.FindElement(By.Id(passwordconfInput));
            passwordconfInputElement.Clear();
            passwordconfInputElement.SendKeys(confpass);
            //title button
            var firstNameInputElement = driver.FindElement(By.Id(firstNameInput));
            firstNameInputElement.Clear();
            firstNameInputElement.SendKeys(firstName);
            var lastNameInputElement = driver.FindElement(By.Id(lastNameInput));
            lastNameInputElement.Clear();
            lastNameInputElement.SendKeys(lastName);
            var emailInputElement = driver.FindElement(By.Id(emailInput));
            emailInputElement.Clear();
            emailInputElement.SendKeys(email);
            var dateOfBirthElement = driver.FindElement(By.Id(dateOfBirthInput));
            dateOfBirthElement.Clear();
            dateOfBirthElement.SendKeys(dateOfBirth);
            var termsCheck = driver.FindElement(By.Id(terms));
            termsCheck.Click();
            var submitButton = driver.FindElement(By.CssSelector(submit));
            submitButton.Submit();

           
        }

        public string UserError()
        {
            var userErrorElement = driver.FindElement(By.CssSelector(userNameError));
            return userErrorElement.Text;
        }

        public string PassError()
        {
            var passErrorElement = driver.FindElement(By.CssSelector(passwordError));
            return passErrorElement.Text;
        }

        public string PassConfError()
        {
            var passConfErrorElement = driver.FindElement(By.CssSelector(confirmPassError));
            return passConfErrorElement.Text;
        }

        public string FirstNameError()
        {
            var firstNameErorrElement = driver.FindElement(By.CssSelector(firstNameErorr));
            return firstNameErorrElement.Text;
        }

        public string LastNameErorr()
        {
            var lastNameErorrElement = driver.FindElement(By.CssSelector(lastNameErorr));
            return lastNameErorrElement.Text;
        }

        public string emailError()
        {
            var emailErorrElement = driver.FindElement(By.CssSelector(emErorr));
            return emailErorrElement.Text;
        }
    }
}
