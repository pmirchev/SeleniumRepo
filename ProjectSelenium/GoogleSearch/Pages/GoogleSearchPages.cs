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

        public IWebElement SearchField => Driver.FindElement(By.XPath("/html/body/div/div[3]/form/div[2]/div[1]/div[1]/div/div[2]/input"));

        public IWebElement FirstResultLink => Driver.FindElement(By.XPath("/html/body/div[6]/div[2]/div[9]/div[1]/div[2]/div/div[2]/div[2]/div/div/div[1]/div/div[1]/a/h3"));

        public string PageTitle => Driver.Title;

        public void AssertCorrectSiteIsOpen(string element)
        {
            Assert.AreEqual("SeleniumHQ Browser Automation", element);
        }
    }
}
