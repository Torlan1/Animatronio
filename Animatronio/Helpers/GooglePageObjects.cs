using Animatronio.WebDriver;
using OpenQA.Selenium;

namespace Animatronio.Helpers
{
    public class GooglePageObjects : BasePageObject
    {
        private readonly Element searchField = new Element(By.CssSelector("input[title='Search']"));

        public void Search(string searchText)
        {
            searchField.Click();
            searchField.SendKeys(searchText);
        }
    }
}