using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using SolutionItems;

namespace GoogleSearch.Pages
{
    public class GoogleSearchPages : BasePage
    {
        public GoogleSearchPages(IWebDriver driver)
            : base(driver)
        {
            PageFactory.InitElements(driver, this);
        }

        public IWebElement SearchField => Driver.FindElement(By.CssSelector("#tsf > div:nth-child(2) > div.A8SBwf > div.RNNXgb > div > div.a4bIc > input"));

        public IWebElement FirstResultLink => Driver.FindElement(By.CssSelector("#rso > div:nth-child(1) > div > div.r > a > h3"));

        public string PageTitle => Driver.Title;

        public void AssertCorrectSiteIsOpen(string element)
        {
            Assert.AreEqual("SeleniumHQ Browser Automation", element);
        }
    }
}
