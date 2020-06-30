using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using SolutionItems;
using SolutionItems.Core;
using System.Collections.Generic;

namespace DemoQA.Pages.InteractionsPages.Selectable
{
    public partial class SelectablePage : BasePage
    {
        public SelectablePage(WebDriver driver)
            : base(driver)
        {
            PageFactory.InitElements((IWebDriver)Driver, this);
        }

        public List<WebElement> SelectableElements => Driver.FindElements(By.XPath("//*[@id='verticalListContainer']//li"));

    }
}
