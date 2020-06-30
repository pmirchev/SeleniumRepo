using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using SolutionItems;
using SolutionItems.Core;

namespace QAAutomation.Pages
{
    public class QAAutomationPages : BasePage
    {
        public QAAutomationPages(WebDriver driver)
            : base(driver)
        {
            PageFactory.InitElements((IWebDriver)driver, this);
        }

        public WebElement CourcesButton => Driver.FindElement(By.XPath("//*[normalize-space(text())='Обучения']"));

        public WebElement ModulesButton => Driver.FindElement(By.XPath("//*[@class='category-nav']//*[normalize-space(text())='Активни модули']"));

        public WebElement QAModuleButton => Driver.FindElement(By.XPath("//*[@class='category-nav']//*[normalize-space(text())='Quality Assurance - октомври 2019']"));

        public WebElement QAAutomationCourceButton => Driver.FindElement(By.XPath("//*[@class='box-content']//*[normalize-space(text())='QA Automation']"));

        public WebElement CourceHeader => Driver.FindElement(By.CssSelector("body > div.content > header > h1"));

        public void AssertSuccessfulNavigationToCorrectCource(WebElement element)
        {
            Assert.IsTrue(element.Text.Contains("QA Automation - май 2020"));
        }

        public override string Url => "https://softuni.bg";
    }
}
