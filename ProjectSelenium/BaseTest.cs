using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;

public class BaseTest
{
    [TestFixture]
    public class BaseTest
    {
        protected IWebDriver Driver;

        protected WebDriverWait Wait;

        protected Actions Builder;

        public void Initialize()
        {
            Driver = new ChromeDriver();
            Driver.Manage().Window.Maximize();
            Wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(3));
            Builder = new Actions(Driver);
        }
    }
}
