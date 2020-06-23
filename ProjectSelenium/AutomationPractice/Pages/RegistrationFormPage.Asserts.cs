using NUnit.Framework;
using OpenQA.Selenium;
using SolutionItems;

namespace AutomationPractice.Pages
{
    public partial class RegistrationFormPage : BasePage
    {
        public void AssertSuccessfullNavigate(IWebElement element)
        {
            Assert.AreEqual("YOUR PERSONAL INFORMATION", element.Text);
        }

        public void AssertSuccessfulRegistration(IWebElement element)
        {
            Assert.IsTrue(element.Displayed);
        }

        public void AssertAllErrorsShown(IWebElement errorsCount)
        {
            Assert.IsTrue(errorsCount.Text.Contains("8 errors"));
        }
        public void AssertErrorMessageShown_When_PhoneNumberIsMissing(IWebElement errorsCount, IWebElement errorMessageText)
        {
            Assert.IsTrue(errorsCount.Text.Contains("There is 1 error"));

            Assert.IsTrue(errorMessageText.Text.Contains("You must register at least one phone number."));
        }

        public void AssertErrorMessageShown_When_StateIsMissing(IWebElement errorsCount, IWebElement errorMessageText)
        {
            Assert.IsTrue(errorsCount.Text.Contains("There is 1 error"));

            Assert.IsTrue(errorMessageText.Text.Contains("requires you to choose a State"));
        }

        public void AssertErrorMessageShown_When_FirstNameIsMissing(IWebElement errorsCount, IWebElement errorMessageText)
        {
            Assert.IsTrue(errorsCount.Text.Contains("There is 1 error"));

            Assert.IsTrue(errorMessageText.Text.Contains("firstname is required."));
        }

        public void AssertErrorMessageShown_When_LastNameIsMissing(IWebElement errorsCount, IWebElement errorMessageText)
        {
            Assert.IsTrue(errorsCount.Text.Contains("There is 1 error"));

            Assert.IsTrue(errorMessageText.Text.Contains("lastname is required."));
        }
    }
}
