using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using SolutionItems;
using SolutionItems.Core;

namespace DemoQA.Pages.InteractionsPages
{
    public class InteractionsNavigation : BasePage
    {
        public InteractionsNavigation(WebDriver driver)
            : base(driver)
        {
            PageFactory.InitElements((IWebDriver)driver, this);
        }

        public WebElement InteractionsButton => Driver.FindElement(By.XPath("//h5[normalize-space(text())='Interactions']/ancestor::*[@class='card mt-4 top-card']"));
    }
}
