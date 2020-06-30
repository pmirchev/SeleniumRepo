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
            Driver.Navigate().GoToUrl("http://demoqa.com/droppable");
            _droppablePage = new DroppablePage(Driver);
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
            var colorBefore = _droppablePage.DroppableBox.GetCssValue("background-color");

            Builder.DragAndDrop(_droppablePage.DragabbleBox, _droppablePage.DroppableBox).Perform();

            var colorAfter = _droppablePage.DroppableBox.GetCssValue("background-color");

            Assert.AreNotEqual(colorBefore, colorAfter);
        }

        [Test]
        public void CorrectPosition_When_DragSourceToNegativeOffset()
        {
            int boxPositionXBefore = _droppablePage.DragabbleBox.Location.X;
            int boxPositionYBefore = _droppablePage.DragabbleBox.Location.Y;

            Builder
                .DragAndDropToOffset(_droppablePage.DragabbleBox, -200, -150)
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
                .DragAndDropToOffset(_droppablePage.DragabbleBox, 200, 150)
                .Perform();

            int boxPositionXAfter = _droppablePage.DragabbleBox.Location.X;
            int boxPositionYAfter = _droppablePage.DragabbleBox.Location.Y;

            Assert.AreEqual(boxPositionXBefore + 200, boxPositionXAfter);
            Assert.AreEqual(boxPositionYBefore + 150, boxPositionYAfter);
        }
    }
}
