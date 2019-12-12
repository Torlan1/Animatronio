using System;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Animatronio.WebDriver
{
    public class WebTestBase
    {
        [ThreadStatic]
        protected static IWebDriver driver;

        public void LaunchBrowser(string browser)
        {
            driver = DriverManager.StartDriver(browser);
        }

        [TearDown]
        public void TearDownTestBase()
        {
            driver.Quit();
        }
    }
}