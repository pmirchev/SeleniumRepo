using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using SolutionItems;

namespace QAAutomation.Pages
{
    public class QAAutomationPages : BasePage
    {
        public QAAutomationPages(IWebDriver driver)
            : base(driver)
        {
            PageFactory.InitElements(driver, this);
        }

        public IWebElement CourcesButton => Driver.FindElement(By.XPath("//*[normalize-space(text())='Обучения']"));

        public IWebElement ModulesButton => Driver.FindElement(By.XPath("//*[@class='category-nav']//*[normalize-space(text())='Активни модули']"));

        public IWebElement QAModuleButton => Driver.FindElement(By.XPath("//*[@class='category-nav']//*[normalize-space(text())='Quality Assurance - октомври 2019']"));

        public IWebElement QAAutomationCourceButton => Driver.FindElement(By.XPath("//*[@class='box-content']//*[normalize-space(text())='QA Automation']"));

        public IWebElement CourceHeader => Driver.FindElement(By.CssSelector("body > div.content > header > h1"));

        public void AssertSuccessfulNavigationToCorrectCource(IWebElement element)
        {
            Assert.IsTrue(element.Text.Contains("QA Automation - май 2020"));
        }
    }
}
