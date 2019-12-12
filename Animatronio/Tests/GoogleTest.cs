using Animatronio.Helpers;
using Animatronio.WebDriver;
using Animatronio.Settings;
using NUnit.Framework;

namespace Animatronio.Tests
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class GoogleTest : WebTestBase
    {
        Config config = new Config();

        [Test, TestCaseSource(typeof(DriverManager), "BrowsersForTest")]
        public void GoogleTest1(string browserName)
        {
            LaunchBrowser(browserName);
            driver.Navigate().GoToUrl(config.GetBaseUrl());
            GooglePageObjects googlePageObjects = new GooglePageObjects();
            googlePageObjects.Search("Hello");
        }
    }
}