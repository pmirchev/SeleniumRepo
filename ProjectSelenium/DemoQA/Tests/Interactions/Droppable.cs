using DemoQA.Pages.InteractionsPages.Droppable;
using NUnit.Framework;
using SolutionItems;

namespace DemoQA.Tests.Interactions
{
    [TestFixture]
    class Droppable : BaseTest
    {
        private DroppablePage _droppablePage;

        [SetUp]
        public void SetUp()
        {
            Initialize();
            _droppablePage = new DroppablePage(Driver);
            _droppablePage.NaviteTo();
        }

        [TearDown]
        public void TearDown()
        {
            Screenshot();
            Driver.Quit();
        }

        [Test]
        public void CorrectPosition_When_DragSourceAndDropOnDestination()
        {
            var colorBefore = _droppablePage.DroppableBox.WrappedElement.GetCssValue("background-color");

            Builder.DragAndDrop((OpenQA.Selenium.IWebElement)_droppablePage.DragabbleBox, target: (OpenQA.Selenium.IWebElement)_droppablePage.DroppableBox).Perform();

            var colorAfter = _droppablePage.DroppableBox.WrappedElement.GetCssValue("background-color");

            Assert.AreNotEqual(colorBefore, colorAfter);
        }

        [Test]
        public void CorrectPosition_When_DragSourceToNegativeOffset()
        {
            int boxPositionXBefore = _droppablePage.DragabbleBox.Location.X;
            int boxPositionYBefore = _droppablePage.DragabbleBox.Location.Y;

            Builder
                .DragAndDropToOffset((OpenQA.Selenium.IWebElement)_droppablePage.DragabbleBox, -200, -150)
                .Perform();

            int boxPositionXAfter = _droppablePage.DragabbleBox.Location.X;
            int boxPositionYAfter = _droppablePage.DragabbleBox.Location.Y;

            Assert.AreEqual(boxPositionXBefore - 200, boxPositionXAfter);
            Assert.AreEqual(boxPositionYBefore - 150, boxPositionYAfter);
        }

        [Test]
        public void CorrectPosition_When_DragSourceToPositiveOffset()
        {
            int boxPositionXBefore = _droppablePage.DragabbleBox.Location.X;
            int boxPositionYBefore = _droppablePage.DragabbleBox.Location.Y;

            Builder
                .DragAndDropToOffset((OpenQA.Selenium.IWebElement)_droppablePage.DragabbleBox, 200, 150)
                .Perform();

            int boxPositionXAfter = _droppablePage.DragabbleBox.Location.X;
            int boxPositionYAfter = _droppablePage.DragabbleBox.Location.Y;

            Assert.AreEqual(boxPositionXBefore + 200, boxPositionXAfter);
            Assert.AreEqual(boxPositionYBefore + 150, boxPositionYAfter);
        }
    }
}
