using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Drawing;
using System.Text;

namespace SolutionItems.Core
{
    public class WebElement
    {
        private readonly IWebDriver _webDriver;
        private readonly IWebElement _webElement;
        private readonly By _by;

        public WebElement(IWebDriver webDriver, IWebElement webElement, By by)
        {
            _webDriver = webDriver;
            _webElement = webElement;
            _by = by;
        }

        public IWebElement WrappedElement => _webElement;

        public void SetText(string text)
        {
            Debug.WriteLine($"Text {text} is weritten in element with locator {By}");
            _webElement.Clear();
            _webElement.SendKeys(text);
        }

        public IWebDriver WrappedDriver => _webDriver;

        public By By => _by;

        public string Text => _webElement?.Text;

        public bool? Enabled => _webElement?.Enabled;

        public bool? Displayed => _webElement?.Displayed;

        public List<WebElement> FindElements(By by)
        {
            var wait = new WebDriverWait(WrappedDriver, TimeSpan.FromSeconds(20));
            ReadOnlyCollection<IWebElement> nativeWebElements =
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.PresenceOfAllElementsLocatedBy(by));
            var elements = new List<WebElement>();
            foreach (var nativeWebElement in nativeWebElements)
            {
                WebElement element = new WebElement(_webDriver, nativeWebElement, by);
                elements.Add(element);
            }

            return elements;
        }

        public Size Size => WrappedElement.Size;

        public Point Location => WrappedElement.Location;

        public void Click()
        {
            WaitToBeClickable(By);
            _webElement?.Click();
        }

        internal WebElement FindElement(By by)
        {
            var wait = new WebDriverWait(WrappedDriver, TimeSpan.FromSeconds(20));
            IWebElement nativeWebElement =
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(by));
            WebElement element = new WebElement(_webDriver, nativeWebElement, by);

            return element;
        }

        public string GetAttribute(string attributeName)
        {
            return _webElement?.GetAttribute(attributeName);
        }

        private void WaitToBeClickable(By by)
        {
            var webDriverWait = new WebDriverWait(_webDriver, TimeSpan.FromSeconds(30));
            webDriverWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(by));
        }
    }
}
