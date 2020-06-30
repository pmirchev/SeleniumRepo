using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using SolutionItems;
using SolutionItems.Core;

namespace DemoQA.Pages.InteractionsPages.Droppable
{
    public partial class DroppablePage : BasePage
    {
        public DroppablePage(WebDriver driver)
            : base(driver)
        {
            PageFactory.InitElements((IWebDriver)Driver, this);
        }

        public WebElement DragabbleBox => Driver.FindElement(By.Id("draggable"));

        public WebElement DroppableBox => Driver.FindElement(By.Id("droppable"));
    }
}
