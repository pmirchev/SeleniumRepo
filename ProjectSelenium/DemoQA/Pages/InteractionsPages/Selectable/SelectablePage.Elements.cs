using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using SolutionItems;
using System.Collections.ObjectModel;

namespace DemoQA.Pages.InteractionsPages.Selectable
{
    public partial class SelectablePage : BasePage
    {
        public SelectablePage(IWebDriver driver)
            : base(driver)
        {
            PageFactory.InitElements(Driver, this);
        }

        public ReadOnlyCollection<IWebElement> SelectableElements => Driver.FindElements(By.XPath("//*[@id='verticalListContainer']//li"));

    }
}
