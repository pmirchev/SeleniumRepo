using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using SolutionItems;
using System.Collections.ObjectModel;

namespace DemoQA.Pages.InteractionsPages.Sortable
{
    public partial class SortablePage : BasePage
    {
        public SortablePage(IWebDriver driver)
            : base(driver)
        {
            PageFactory.InitElements(driver, this);
        }

        public ReadOnlyCollection<IWebElement> SortableElements => Driver.FindElements(By.XPath("//*[@id='demo-tabpane-list']//div/div"));

    }
}
