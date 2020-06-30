using NUnit.Framework;
using OpenQA.Selenium;
using SolutionItems;
using SolutionItems.Core;

namespace AutomationPractice.Pages
{
    public partial class RegistrationFormPage : BasePage
    {
        public void AssertSuccessfullNavigate(WebElement element)
        {
            Assert.AreEqual("YOUR PERSONAL INFORMATION", element.Text);
        }

        public void AssertSuccessfulRegistration(WebElement element)
        {
            Assert.IsTrue(element.Displayed);
        }

        public void AssertAllErrorsShown(WebElement errorsCount)
        {
            Assert.IsTrue(errorsCount.Text.Contains("8 errors"));
        }
        public void AssertErrorMessageShown_When_PhoneNumberIsMissing(WebElement errorsCount, WebElement errorMessageText)
        {
            Assert.IsTrue(errorsCount.Text.Contains("There is 1 error"));

            Assert.IsTrue(errorMessageText.Text.Contains("You must register at least one phone number."));
        }

        public void AssertErrorMessageShown_When_StateIsMissing(WebElement errorsCount, WebElement errorMessageText)
        {
            Assert.IsTrue(errorsCount.Text.Contains("There is 1 error"));

            Assert.IsTrue(errorMessageText.Text.Contains("requires you to choose a State"));
        }

        public void AssertErrorMessageShown_When_FirstNameIsMissing(WebElement errorsCount, WebElement errorMessageText)
        {
            Assert.IsTrue(errorsCount.Text.Contains("There is 1 error"));

            Assert.IsTrue(errorMessageText.Text.Contains("firstname is required."));
        }

        public void AssertErrorMessageShown_When_LastNameIsMissing(WebElement errorsCount, WebElement errorMessageText)
        {
            Assert.IsTrue(errorsCount.Text.Contains("There is 1 error"));

            Assert.IsTrue(errorMessageText.Text.Contains("lastname is required."));
        }
    }
}
