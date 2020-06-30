using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using SolutionItems;
using SolutionItems.Core;

namespace DemoQA.Pages.InteractionsPages.Resizable
{
    public partial class ResizablePage : BasePage
    {
        public ResizablePage(WebDriver driver)
            : base(driver)
        {
            PageFactory.InitElements((IWebDriver)Driver, this);
        }

        public WebElement ResizableBoxWithRestriction => Driver.FindElement(By.Id("resizableBoxWithRestriction"));

        public WebElement ResizableBoxWithRestrictionHandle => Driver.FindElement(By.XPath("//*[@id='resizableBoxWithRestriction']/span"));

        public WebElement ResizableBoxWithoutRestriction => Driver.FindElement(By.XPath("//*[@id='resizable']"));

        public WebElement ResizableBoxWithoutRestrictionHandle => Driver.FindElement(By.XPath("//*[@id='resizable']/span"));
    }
}
