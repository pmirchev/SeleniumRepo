using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using SolutionItems;

namespace DemoQA.Pages.InteractionsPages
{
    public class InteractionsNavigation : BasePage
    {
        public InteractionsNavigation(IWebDriver driver)
            : base(driver)
        {
            PageFactory.InitElements(driver, this);
        }

        public IWebElement InteractionsButton => Driver.FindElement(By.XPath("//h5[normalize-space(text())='Interactions']/ancestor::*[@class='card mt-4 top-card']"));
    }
}
