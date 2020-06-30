using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using SolutionItems;
using SolutionItems.Core;

namespace DemoQA.Pages.InteractionsPages.Draggable
{
    public partial class DraggablePage : BasePage
    {
        public DraggablePage(WebDriver driver)
            : base(driver)
        {
            PageFactory.InitElements((IWebDriver)Driver, this);
        }

        public WebElement DragabbleBox => Driver.FindElement(By.Id("dragBox"));
    }
}
