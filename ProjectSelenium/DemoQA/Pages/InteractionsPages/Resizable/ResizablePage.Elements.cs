using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using SolutionItems;

namespace DemoQA.Pages.InteractionsPages.Resizable
{
    public partial class ResizablePage : BasePage
    {
        public ResizablePage(IWebDriver driver)
            : base(driver)
        {
            PageFactory.InitElements(Driver, this);
        }

        public IWebElement ResizableBoxWithRestriction => Driver.FindElement(By.Id("resizableBoxWithRestriction"));

        public IWebElement ResizableBoxWithRestrictionHandle => Driver.FindElement(By.XPath("//*[@id='resizableBoxWithRestriction']/span"));

        public IWebElement ResizableBoxWithoutRestriction => Driver.FindElement(By.XPath("//*[@id='resizable']"));

        public IWebElement ResizableBoxWithoutRestrictionHandle => Driver.FindElement(By.XPath("//*[@id='resizable']/span"));
    }
}
