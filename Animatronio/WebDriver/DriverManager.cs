using System.Collections.Generic;
using System.Threading;
using Animatronio.Settings;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace Animatronio.WebDriver
{
    public static class DriverManager
    {
        /// <summary>
        /// The list of webdriver instances currently stored.  Each Test has it's own instance of webdriver.
        /// This supports parallel executions of tests and multiple instances of webdriver
        /// If additional instances are needed for a test they must be added manually
        /// </summary>
        public static ThreadLocal<IWebDriver> WebDrivers { get; set; } = new ThreadLocal<IWebDriver>();

        public static IWebDriver StartDriver(string browserName)
        {
            IWebDriver driver = null;
            if(browserName == "Chrome")
            {
                driver = new ChromeDriver();
            }
            if (browserName == "Firefox")
            {
                driver = new FirefoxDriver();
            }
            return WebDrivers.Value = driver;
        }

        public static IEnumerable<string> BrowsersForTest()
        {
            var browsers = new List<string>();
            for (var i = 1; i < 6; i++)
            {
                var browser = Config.GetConfigValue("Browser" + i, "null");
                if (browser != "null")
                {
                    browsers.Add(browser);
                }
            }
            foreach (string b in browsers)
            {
                yield return b;
            }
        }

        /// <summary>
        /// Gets the current instance of webdriver based upon the current test name.
        /// IF a new browser is needed use StartDriver() instead
        /// </summary>
        /// <returns></returns>
        public static IWebDriver GetDriver()
        {
            return WebDrivers.Value;
        }
    }
}