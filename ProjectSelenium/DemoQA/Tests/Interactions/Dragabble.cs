using DemoQA.Pages.InteractionsPages.Draggable;
using NUnit.Framework;
using OpenQA.Selenium;
using SolutionItems;

namespace DemoQA.Tests.Interactions
{
    [TestFixture]
    class Dragabble : BaseTest
    {
        private DraggablePage _draggablePage;

        [SetUp]
        public void SetUp()
        {
            Initialize();
            Driver.Navigate().GoToUrl("http://demoqa.com/dragabble");
            _draggablePage = new DraggablePage(Driver);
        }

        [TearDown]
        public void TearDown()
        {
            Screenshot();
            Driver.Quit();
        }

        [Test]
        public void CorrectPosition_When_DragBoxToPositivePosition()
        {
            var boxPositionXBefore = _draggablePage.DragabbleBox.Location.X;
            var boxPositionYBefore = _draggablePage.DragabbleBox.Location.Y;

            Builder
                .DragAndDropToOffset(_draggablePage.DragabbleBox, 500, 150)
                .Perform();

            var newPositionX = _draggablePage.DragabbleBox.Location.X;
            var newPositionY = _draggablePage.DragabbleBox.Location.Y;

            Assert.AreEqual(boxPositionXBefore + 500, newPositionX);
            Assert.AreEqual(boxPositionYBefore + 150, newPositionY);
        }

        [Test]
        public void CorrectPosition_When_DragBoxToNegativePosition()
        {
            var boxPositionXBefore = _draggablePage.DragabbleBox.Location.X;
            var boxPositionYBefore = _draggablePage.DragabbleBox.Location.Y;

            Builder
                .DragAndDropToOffset(_draggablePage.DragabbleBox, -200, -150)
                .Perform();

            var newPositionX = _draggablePage.DragabbleBox.Location.X;
            var newPositionY = _draggablePage.DragabbleBox.Location.Y;

            Assert.AreEqual(boxPositionXBefore - 200, newPositionX);
            Assert.AreEqual(boxPositionYBefore - 150, newPositionY);
        }

        [Test]
        public void ErrorMessageIsThrown_When_DragBoxOutsideTheWindow()
        {
            Assert.Throws<WebDriverException>(() => Builder.DragAndDropToOffset(_draggablePage.DragabbleBox, -600, -300).Perform());
        }
    }
}
