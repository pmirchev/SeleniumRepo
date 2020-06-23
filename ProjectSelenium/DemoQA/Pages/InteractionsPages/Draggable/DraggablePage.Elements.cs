using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using SolutionItems;

namespace DemoQA.Pages.InteractionsPages.Draggable
{
    public partial class DraggablePage : BasePage
    {
        public DraggablePage(IWebDriver driver)
            : base(driver)
        {
            PageFactory.InitElements(Driver, this);
        }

        public IWebElement DragabbleBox => Driver.FindElement(By.Id("dragBox"));
    }
}
