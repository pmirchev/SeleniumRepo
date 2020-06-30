using AutomationPractice.Models;
using OpenQA.Selenium.Support.UI;
using SolutionItems;

namespace AutomationPractice.Pages
{
    public partial class RegistrationFormPage : BasePage
    {
        public void FillForm(FormModel user)
        {
            FirstName.SendKeys(user.FirstName);
            LastName.SendKeys(user.LastName);
            Password.SendKeys(user.Password);
            Address.SendKeys(user.Address);
            City.SendKeys(user.City);
            PostCode.SendKeys(user.PostCode);
            PhoneNumber.SendKeys(user.PhoneNumber);
            SelectElement selectElementFromDropDownList = new SelectElement(State);
            selectElementFromDropDownList.SelectByText("Alabama");

            Driver.ScrollTo(RegisterButton);
            RegisterButton.Click();
        }

        public void FillFormWithoutState(FormModel user)
        {
            FirstName.SendKeys(user.FirstName);
            LastName.SendKeys(user.LastName);
            Password.SendKeys(user.Password);
            Address.SendKeys(user.Address);
            City.SendKeys(user.City);
            PostCode.SendKeys(user.PostCode);
            PhoneNumber.SendKeys(user.PhoneNumber);

            Driver.ScrollTo(RegisterButton);
            RegisterButton.Click();
        }
    }
}
