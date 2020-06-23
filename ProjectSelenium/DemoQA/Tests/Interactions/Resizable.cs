using DemoQA.Pages.InteractionsPages.Resizable;
using NUnit.Framework;
using OpenQA.Selenium;
using SolutionItems;

namespace DemoQA.Tests.Interactions
{
    [TestFixture]
    class Resizable : BaseTest
    {
        private ResizablePage _resizablePage;
        [SetUp]
        public void SetUp()
        {
            Initialize();
            Driver.Navigate().GoToUrl("http://demoqa.com/resizable");
            _resizablePage = new ResizablePage(Driver);
        }

        [TearDown]
        public void TearDown()
        {
            Screenshot();
            Driver.Quit();
        }

        [Test]
        public void SuccessfullyResized_When_DragWithinLimits()
        {
            Builder
                .ClickAndHold(_resizablePage.ResizableBoxWithRestrictionHandle)
                .MoveByOffset(150, 100)
                .Release()
                .Perform();

            var widthAfter = _resizablePage.ResizableBoxWithRestriction.GetCssValue("width");
            var heightAfter = _resizablePage.ResizableBoxWithRestriction.GetCssValue("height");

            Assert.AreEqual("350px", widthAfter);
            Assert.AreEqual("300px", heightAfter);
        }

        [Test]
        public void SuccessfullyResized_When_DragWithoutLimits()
        {
            IWebElement pageFooter = Driver.FindElement(By.Id("botton-text-10"));
            Driver.ScrollTo(pageFooter);

            Builder
                .ClickAndHold(_resizablePage.ResizableBoxWithoutRestrictionHandle)
                .MoveByOffset(350, 250)
                .Release()
                .Perform();

            var widthAfter = _resizablePage.ResizableBoxWithoutRestriction.GetCssValue("width");
            var heightAfter = _resizablePage.ResizableBoxWithoutRestriction.GetCssValue("height");

            Assert.AreEqual("550px", widthAfter);
            Assert.AreEqual("450px", heightAfter);
        }
    }
}
