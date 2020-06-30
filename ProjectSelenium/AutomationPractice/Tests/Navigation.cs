using AutoFixture;
using AutomationPractice.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using SolutionItems;
using System;

namespace AutomationPractice.Tests
{
    [TestFixture]
    public class NavigationToUrl : BaseTest
    {
        private RegistrationFormPage _registrationsFormPage;

        [SetUp]
        public void Setup()
        {
            Initialize();
            Driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
            _registrationsFormPage = new RegistrationFormPage(Driver);
        }

        [TearDown]
        public void TearDown()
        {
            Screenshot();
            Driver.Quit();
        }

        [Test]
        public void NavigateToRegistrationPage()
        {
            var fixture = new Fixture();
            var mail = fixture.Create<string>() + "@gmail.com";

            _registrationsFormPage.SignInButton.Click();
            _registrationsFormPage.EmailAddressField.SendKeys(mail);
            _registrationsFormPage.CreateAccountButton.Click();

            _registrationsFormPage.AssertSuccessfullNavigate(_registrationsFormPage.PageSubHeading);
        }
    }
}
