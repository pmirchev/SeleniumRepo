using AutomationPractice.Models;
using OpenQA.Selenium.Support.UI;
using SolutionItems;

namespace AutomationPractice.Pages
{
    public partial class RegistrationFormPage : BasePage
    {
        public void FillForm(FormModel user)
        {
            FirstName.WrappedElement.SendKeys(user.FirstName);
            LastName.WrappedElement.SendKeys(user.LastName);
            Password.WrappedElement.SendKeys(user.Password);
            Address.WrappedElement.SendKeys(user.Address);
            City.WrappedElement.SendKeys(user.City);
            PostCode.WrappedElement.SendKeys(user.PostCode);
            PhoneNumber.WrappedElement.SendKeys(user.PhoneNumber);
            SelectElement selectElementFromDropDownList = new SelectElement((OpenQA.Selenium.IWebElement)State);
            selectElementFromDropDownList.SelectByText("Alabama");

            Driver.WrappedDriver.ScrollTo((OpenQA.Selenium.IWebElement)RegisterButton);
            RegisterButton.Click();
        }

        public void FillFormWithoutState(FormModel user)
        {
            FirstName.WrappedElement.SendKeys(user.FirstName);
            LastName.WrappedElement.SendKeys(user.LastName);
            Password.WrappedElement.SendKeys(user.Password);
            Address.WrappedElement.SendKeys(user.Address);
            City.WrappedElement.SendKeys(user.City);
            PostCode.WrappedElement.SendKeys(user.PostCode);
            PhoneNumber.WrappedElement.SendKeys(user.PhoneNumber);

            Driver.WrappedDriver.ScrollTo((OpenQA.Selenium.IWebElement)RegisterButton);
            RegisterButton.Click();
        }

        public override string Url => "http://automationpractice.com/index.php?controller=authentication&back=my-account";
    }
}
