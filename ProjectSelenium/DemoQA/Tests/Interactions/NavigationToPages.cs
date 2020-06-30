using DemoQA.Pages.InteractionsPages;
using NUnit.Framework;
using OpenQA.Selenium;
using SolutionItems;

namespace DemoQA.Tests.Interactions
{
    [TestFixture]
    public class NavigationToPages : BaseTest
    {
        private InteractionsNavigation _interactionsNavigation;

        [SetUp]
        public void SetUp()
        {
            Initialize();
            Driver.GoToUrl("http://demoqa.com/");
            _interactionsNavigation = new InteractionsNavigation(Driver);
        }

        [TearDown]
        public void TearDown()
        {
            Screenshot();
            Driver.Quit();
        }

        [Test]
        [TestCase("Sortable")]
        [TestCase("Selectable")]
        [TestCase("Resizable")]
        [TestCase("Droppable")]
        [TestCase("Dragabble")]
        public void SuccessfullyPageLoading_When_NavigateToSectionUrl(string sectionName)
        {
            _interactionsNavigation.InteractionsButton.Click();

            IWebElement sectionButton = (IWebElement)Driver.FindElement(By.XPath($"//*[normalize-space(text())='{sectionName}']"));
            Driver.WrappedDriver.ScrollTo(sectionButton);
            sectionButton.Click();

            string mainHeaderText = Driver.FindElement(By.ClassName("main-header")).Text;
            Assert.AreEqual(sectionName, mainHeaderText);
        }
    }
}
