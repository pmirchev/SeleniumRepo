using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using SolutionItems;
using SolutionItems.Core;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace DemoQA.Pages.InteractionsPages.Sortable
{
    public partial class SortablePage : BasePage
    {
        public SortablePage(WebDriver driver)
            : base(driver)
        {
            PageFactory.InitElements((IWebDriver)driver, this);
        }

        public List<WebElement> SortableElements => Driver.FindElements(By.XPath("//*[@id='demo-tabpane-list']//div/div"));

    }
}
