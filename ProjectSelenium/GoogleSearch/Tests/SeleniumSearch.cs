using GoogleSearch.Pages;
using NUnit.Framework;
using SolutionItems;

namespace GoogleSearch.Tests
{
    [TestFixture]
    public class SeleniumSearch : BaseTest
    {
        private GoogleSearchPages _googleSearchPages;

        [SetUp]
        public void SetUp()
        {
            Initialize();
            Driver.Url = "http://www.google.com";
            _googleSearchPages = new GoogleSearchPages(Driver);
        }

        [TearDown]
        public void TearDown()
        {
            Screenshot();
            Driver.Quit();
        }

        [Test]
        public void OpenSeleniumPage_When_ClickOnFirstResult()
        {
            _googleSearchPages.SearchField.SendKeys("selenium");
            _googleSearchPages.SearchField.Submit();

            _googleSearchPages.FirstResultLink.Click();

            _googleSearchPages.AssertCorrectSiteIsOpen(_googleSearchPages.PageTitle);
        }
    }
}