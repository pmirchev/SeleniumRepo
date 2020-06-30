using DemoQA.Pages.InteractionsPages.Selectable;
using NUnit.Framework;
using SolutionItems;

namespace DemoQA.Tests.Interactions
{
    [TestFixture]
    class Selectable : BaseTest
    {
        private SelectablePage _selectablePage;

        [SetUp]
        public void SetUp()
        {
            Initialize();
            _selectablePage = new SelectablePage(Driver);
            _selectablePage.NaviteTo();
        }

        [TearDown]
        public void TearDown()
        {
            Screenshot();
            Driver.Quit();
        }

        [Test]
        public void SuccessfullySelected_When_ClickOnElement()
        {
            var colorBefore = _selectablePage.SelectableElements[0].WrappedElement.GetCssValue("color");
            _selectablePage.SelectableElements[0].Click();

            var colorAfter = _selectablePage.SelectableElements[0].WrappedElement.GetCssValue("color");

            Assert.AreNotEqual(colorBefore, colorAfter);
        }

        [Test]
        public void SuccessfullyUnSelected_When_ClickOnSelectedElement()
        {
            var colorBefore = _selectablePage.SelectableElements[0].WrappedElement.GetCssValue("color");
            _selectablePage.SelectableElements[0].Click();
            _selectablePage.SelectableElements[0].Click();

            var colorAfter = _selectablePage.SelectableElements[0].WrappedElement.GetCssValue("color");

            Assert.AreEqual(colorBefore, colorAfter);
        }

        [Test]
        public void SuccessfullySelected_When_ClickOnMultipleElement()
        {
            var firstElementColorBefore = _selectablePage.SelectableElements[0].WrappedElement.GetCssValue("color");
            var secondElementColorBefore = _selectablePage.SelectableElements[1].WrappedElement.GetCssValue("color");

            _selectablePage.SelectableElements[0].Click();
            _selectablePage.SelectableElements[1].Click();

            var firstElementColorAfter = _selectablePage.SelectableElements[0].WrappedElement.GetCssValue("color");
            var secondElementColorAfter = _selectablePage.SelectableElements[1].WrappedElement.GetCssValue("color");

            Assert.AreNotEqual(firstElementColorBefore, firstElementColorAfter);
            Assert.AreNotEqual(secondElementColorBefore, secondElementColorAfter);
        }
    }
}
