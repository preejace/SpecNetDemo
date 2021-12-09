using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SpecNetDemo.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SpecNetDemo.Steps
{
    [Binding]
    public sealed class LoginSteps
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef
        LoginPage loginpage = null;


        [Given(@"I launch the EA Site")]
        public void GivenILaunchTheEASite()
        {
            IWebDriver webDriver = new ChromeDriver();
            webDriver.Navigate().GoToUrl("http://eaapp.somee.com/");
            loginpage = new LoginPage(webDriver);

        }
        
        [Given(@"I click the Login link")]
        public void GivenIClickTheLoginLink()
        {
            loginpage.ClickLogin();
        }
        
        [When(@"I enter the following details")]
        public void WhenIEnterTheFollowingDetails(Table table)
        {

            dynamic data = table.CreateDynamicInstance();
            loginpage.Login((string)data.UserName, (string)data.Password);
        }
        
        [When(@"I click the Login button")]
        public void WhenIClickTheLoginButton() => loginpage.ClickLoginbutton();
        
        [Then(@"I should be displayed the Employee details link")]
        public void ThenIShouldBeDisplayedTheEmployeeDetailsLink()
        {
            Assert.That(loginpage.IsEmployeeDetailsExist(), Is.True);
                
        }

    }
}
