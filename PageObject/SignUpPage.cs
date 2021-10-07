using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support;
using RMK_Chrome_Project.Utilities;

namespace RMK_Chrome_Project.PageObject
{
    class SignUpPage
    {
        public SignUpPage()
        {
            driver = Hooks1.driver;
        }

        IWebDriver driver;

        public static Random randomGenerator = new Random();
        int randomInt = randomGenerator.Next(1000);

        IWebElement username => driver.FindElement(By.XPath("//input[@placeholder='Username']"));
        public void EnterUsername()
        {
            username.SendKeys("TestUser" + randomInt);
        }

        IWebElement email => driver.FindElement(By.XPath("//input[@placeholder='Email']"));
        public void EnterEmail()
        {
            email.SendKeys("testuser" + randomInt + "@test.com");
        }

        IWebElement password => driver.FindElement(By.XPath("//input[@placeholder='Password']"));
        public void EnterPassword()
        {
            password.SendKeys("TestPassword");
        }

        IWebElement signUp => driver.FindElement(By.CssSelector("body > div > div > div > div > div > div > form > fieldset > button"));
        public void ClickSignUpButton()
        {
            signUp.Click();
        }

        public bool IsPopularTagsDisplayed()
        {
            return popularTags.Displayed;
        }

        IWebElement popularTags => driver.FindElement(By.XPath("//p[text()='Popular Tags']"));
        public void NavigateToWebSite()
        {
            driver.Navigate().GoToUrl("https://angularjs.realworld.io/#/register");
        }

    }
}