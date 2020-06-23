using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using SolutionItems;

namespace DemoQA.Pages.InteractionsPages.Droppable
{
    public partial class DroppablePage : BasePage
    {
        public DroppablePage(IWebDriver driver)
            : base(driver)
        {
            PageFactory.InitElements(Driver, this);
        }

        public IWebElement DragabbleBox => Driver.FindElement(By.Id("draggable"));

        public IWebElement DroppableBox => Driver.FindElement(By.Id("droppable"));
    }
}
