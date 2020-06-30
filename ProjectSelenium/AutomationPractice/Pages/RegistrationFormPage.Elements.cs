using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using SolutionItems;
using SolutionItems.Core;

namespace AutomationPractice.Pages
{
    public partial class RegistrationFormPage : BasePage
    {
        public RegistrationFormPage(WebDriver driver)
            : base(driver)
        {
            PageFactory.InitElements((IWebDriver)Driver, this);
        }

        public WebElement SignInButton => Driver.FindElement(By.ClassName("login"));

        public WebElement EmailAddressField => Driver.FindElement(By.CssSelector("#email_create"));

        public WebElement CreateAccountButton => Driver.FindElement(By.Id("SubmitCreate"));

        public WebElement PageSubHeading => Driver.FindElement(By.XPath("//*[normalize-space(text())='Your personal information']"));

        public WebElement FirstName => Driver.FindElement(By.Id("customer_firstname"));

        public WebElement LastName => Driver.FindElement(By.Id("customer_lastname"));

        public WebElement Password => Driver.FindElement(By.Id("passwd"));

        public WebElement Address => Driver.FindElement(By.Id("address1"));

        public WebElement City => Driver.FindElement(By.Id("city"));

        public WebElement PostCode => Driver.FindElement(By.Id("postcode"));

        public WebElement State => Driver.FindElement(By.Id("id_state"));

        public WebElement PhoneNumber => Driver.FindElement(By.Id("phone_mobile"));

        public WebElement RegisterButton => Driver.FindElement(By.XPath("//*[@id='submitAccount']/span"));

        public WebElement LogoutButton => Driver.FindElement(By.ClassName("logout"));

        public WebElement CustomerNames => Driver.FindElement(By.ClassName("account"));

        public WebElement ErrorMessageCount => Driver.FindElement(By.CssSelector("#center_column > div > p"));

        public WebElement ErrorMessageText => Driver.FindElement(By.CssSelector("#center_column > div > ol > li"));

    }
}
