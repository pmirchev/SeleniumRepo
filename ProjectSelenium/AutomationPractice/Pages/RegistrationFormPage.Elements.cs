using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using SolutionItems;

namespace AutomationPractice.Pages
{
    public partial class RegistrationFormPage : BasePage
    {
        public RegistrationFormPage(IWebDriver driver)
            : base(driver)
        {
            PageFactory.InitElements(Driver, this);
        }

        public IWebElement SignInButton => Driver.FindElement(By.ClassName("login"));

        public IWebElement EmailAddressField => Driver.FindElement(By.CssSelector("#email_create"));

        public IWebElement CreateAccountButton => Driver.FindElement(By.Id("SubmitCreate"));

        public IWebElement PageSubHeading => Driver.FindElement(By.XPath("//*[normalize-space(text())='Your personal information']"));

        public IWebElement FirstName => Driver.FindElement(By.Id("customer_firstname"));

        public IWebElement LastName => Driver.FindElement(By.Id("customer_lastname"));

        public IWebElement Password => Driver.FindElement(By.Id("passwd"));

        public IWebElement Address => Driver.FindElement(By.Id("address1"));

        public IWebElement City => Driver.FindElement(By.Id("city"));

        public IWebElement PostCode => Driver.FindElement(By.Id("postcode"));

        public IWebElement State => Driver.FindElement(By.Id("id_state"));

        public IWebElement PhoneNumber => Driver.FindElement(By.Id("phone_mobile"));

        public IWebElement RegisterButton => Driver.FindElement(By.XPath("//*[@id='submitAccount']/span"));

        public IWebElement LogoutButton => Driver.FindElement(By.ClassName("logout"));

        public IWebElement CustomerNames => Driver.FindElement(By.ClassName("account"));

        public IWebElement ErrorMessageCount => Driver.FindElement(By.CssSelector("#center_column > div > p"));

        public IWebElement ErrorMessageText => Driver.FindElement(By.CssSelector("#center_column > div > ol > li"));

    }
}
