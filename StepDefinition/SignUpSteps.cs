using System;
using System.Threading;
using NUnit.Framework;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support;
using RMK_Chrome_Project.PageObject;

namespace RMK_Chrome_Project.StepDefinition
{
    [Binding]
    public class SignUpSteps
    {

        SignUpPage signUpPage;

        public SignUpSteps()
        {
            signUpPage = new SignUpPage();
        }

        [Given(@"I navigate to the website")]
        public void GivenINavigateToTheWebsite()
        {
            signUpPage.NavigateToWebSite();
        }

        [Given(@"I enter my Username")]
        public void GivenIEnterMyUsername()
        {
            signUpPage.EnterUsername();
        }

        [Given(@"I enter my Email")]
        public void GivenIEnterMyEmail()
        {
            signUpPage.EnterEmail();
        }

        [Given(@"I enter my Password")]
        public void GivenIEnterMyPassword()
        {
            signUpPage.EnterPassword();
        }

        [When(@"I click on Sign up")]
        public void WhenIClickOnSignUp()
        {
            signUpPage.ClickSignUpButton();
        }

        [Then(@"I should be able to register succesfully")]
        public void ThenIShouldBeAbleToRegisterSuccesfully()
        {
            Thread.Sleep(5000);
            Assert.That(signUpPage.IsPopularTagsDisplayed);
        }
    }
}