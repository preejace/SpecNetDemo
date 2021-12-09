using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpecNetDemo.Pages
{
    class LoginPage
    {

        public IWebDriver WebDriver { get; }

        public LoginPage(IWebDriver webDriver)
        {
            WebDriver = webDriver;
        }

        public IWebElement linkLogin => WebDriver.FindElement(By.LinkText("Login"));
        public IWebElement txtUserName => WebDriver.FindElement(By.Id("UserName"));
        public IWebElement txtPassword => WebDriver.FindElement(By.Id("Password"));
        public IWebElement LoginButton => WebDriver.FindElement(By.ClassName("btn-default"));
        public IWebElement linkEmployeeDetails => WebDriver.FindElement(By.LinkText("Employee List"));


        public void ClickLogin() => linkLogin.Click();
        public void Login(string userName , string Password)
        {
            txtUserName.SendKeys(userName);
            txtPassword.SendKeys(Password);
        }

        public void ClickLoginbutton() => LoginButton.Submit();
        public bool IsEmployeeDetailsExist() => linkEmployeeDetails.Displayed;

    }
}
