using DemoQA.Pages.InteractionsPages.Sortable;
using NUnit.Framework;
using OpenQA.Selenium.Interactions;
using SolutionItems;

namespace DemoQA.Tests.Interactions
{
    [TestFixture]
    class Sortable : BaseTest
    {
        private SortablePage _sortablePagePage;

        [SetUp]
        public void SetUp()
        {
            Initialize();
            _sortablePagePage = new SortablePage(Driver);
            _sortablePagePage.NaviteTo();
        }

        [TearDown]
        public void TearDown()
        {
            Screenshot();
            Driver.Quit();
        }

        [Test]
        public void CorrectOrger_When_ChangePlacesOfFirstTwoElements()
        {
            string firstElementBefore = _sortablePagePage.SortableElements[0].Text;
            string secondElementBefore = _sortablePagePage.SortableElements[1].Text;

            Builder
                .ClickAndHold((OpenQA.Selenium.IWebElement)_sortablePagePage.SortableElements[0])
                .MoveToElement((OpenQA.Selenium.IWebElement)_sortablePagePage.SortableElements[1])
                .Release()
                .Perform();

            string firstElementAfter = _sortablePagePage.SortableElements[0].Text;
            string secondElementAfter = _sortablePagePage.SortableElements[1].Text;

            Assert.AreNotEqual(firstElementBefore, firstElementAfter);
            Assert.AreNotEqual(secondElementBefore, secondElementAfter);
            Assert.AreEqual("Two", firstElementAfter);
            Assert.AreEqual("One", secondElementAfter);
        }

        [Test]
        public void CorrectOrger_When_ChangePlacesOfFirstAndLastElements()
        {
            string firstElementBefore = _sortablePagePage.SortableElements[0].Text;
            string lastElementBefore = _sortablePagePage.SortableElements[5].Text;

            Builder
                .ClickAndHold((OpenQA.Selenium.IWebElement)_sortablePagePage.SortableElements[0])
                .MoveToElement((OpenQA.Selenium.IWebElement)_sortablePagePage.SortableElements[5])
                .Release()
                .Perform();

            var _bulderForElemetSix = new Actions(Driver.WrappedDriver);

            _bulderForElemetSix
                .ClickAndHold((OpenQA.Selenium.IWebElement)_sortablePagePage.SortableElements[4])
                .MoveToElement((OpenQA.Selenium.IWebElement)_sortablePagePage.SortableElements[0])
                .Release()
                .Perform();

            string firstElementAfter = _sortablePagePage.SortableElements[0].Text;
            string lastElementAfter = _sortablePagePage.SortableElements[5].Text;

            Assert.AreEqual("One", firstElementBefore);
            Assert.AreEqual("Six", lastElementBefore);
            Assert.AreEqual("Six", firstElementAfter);
            Assert.AreEqual("One", lastElementAfter);
        }
    }
}
