using AutoFixture;
using AutomationPractice.Factories;
using AutomationPractice.Models;
using AutomationPractice.Pages;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using SolutionItems;

namespace AutomationPractice.Tests
{
    [TestFixture]
    public class RegistrationPageTests : BaseTest
    {
        private RegistrationFormPage _registrationFormPage;
        private FormModel _user;

        [SetUp]
        public void Setup()
        {
            Initialize();
            _registrationFormPage = new RegistrationFormPage(Driver);
            _registrationFormPage.NaviteTo();
            _user = FormFactory.Create();

            var fixture = new Fixture();
            var mail = fixture.Create<string>() + "@gmail.com";
            _registrationFormPage.EmailAddressField.WrappedElement.SendKeys(mail);
            _registrationFormPage.CreateAccountButton.Click();
        }

        [TearDown]
        public void TearDown()
        {
            Screenshot();
            Driver.Quit();
        }

        [Test]
        public void SuccessfulRegistration()
        {
            _registrationFormPage.FillForm(_user);

            _registrationFormPage.AssertSuccessfulRegistration(_registrationFormPage.LogoutButton);
            _registrationFormPage.AssertSuccessfulRegistration(_registrationFormPage.CustomerNames);
        }

        [Test]
        public void AllErrorMessagesAreShown_When_RegisterButtonIsClicked_With_NoDataEntered()
        {
            _registrationFormPage.RegisterButton.Click();

            _registrationFormPage.AssertAllErrorsShown(_registrationFormPage.ErrorMessageCount);
        }
        
        [Test]
        public void PhoneNumberIsRequired_When_TheNumberFieldIsEmpty()
        {
            _user.PhoneNumber = string.Empty;

            _registrationFormPage.FillForm(_user);

            _registrationFormPage.AssertErrorMessageShown_When_PhoneNumberIsMissing(_registrationFormPage.ErrorMessageCount, _registrationFormPage.ErrorMessageText);
        }
        
        [Test]
        public void StateIsRequired_When_StateFieldIsEmpty()
        {
            _registrationFormPage.FillFormWithoutState(_user);

            _registrationFormPage.AssertErrorMessageShown_When_StateIsMissing(_registrationFormPage.ErrorMessageCount, _registrationFormPage.ErrorMessageText);
        }
        
        [Test]
        public void FirstNameIsRequired_When_FirstNameFieldIsEmpty()
        {
            _user.FirstName = string.Empty;

            _registrationFormPage.FillForm(_user);

            _registrationFormPage.AssertErrorMessageShown_When_FirstNameIsMissing(_registrationFormPage.ErrorMessageCount, _registrationFormPage.ErrorMessageText);
        }
        
        [Test]
        public void LastNameIsRequired_When_LastNameFieldIsEmpty()
        {
            _user.LastName = string.Empty;

            _registrationFormPage.FillForm(_user);

            _registrationFormPage.AssertErrorMessageShown_When_LastNameIsMissing(_registrationFormPage.ErrorMessageCount, _registrationFormPage.ErrorMessageText);
        }
    }
}
