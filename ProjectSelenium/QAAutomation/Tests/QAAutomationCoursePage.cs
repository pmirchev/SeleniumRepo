using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using QAAutomation.Pages;
using SolutionItems;

namespace QAAutomation.Tests
{
    public class QAAutomationCoursePage : BaseTest
    {
        private QAAutomationPages _qaAutomationPages;

        [SetUp]
        public void SetUp()
        {
            Initialize();
            _qaAutomationPages = new QAAutomationPages(Driver);
            _qaAutomationPages.NaviteTo();
        }

        [TearDown]
        public void TearDown()
        {
            Screenshot();
            Driver.Quit();
        }

        [Test]
        [System.Obsolete]
        public void SuccessfulNavigationToQAAutomationCoursePage()
        {
            _qaAutomationPages.CourcesButton.Click();
            _qaAutomationPages.ModulesButton.Click();
            _qaAutomationPages.QAModuleButton.Click();
            _qaAutomationPages.QAAutomationCourceButton.Click();

            _qaAutomationPages.AssertSuccessfulNavigationToCorrectCource(_qaAutomationPages.CourceHeader);
        }
    }
}
