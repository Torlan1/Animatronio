using OpenQA.Selenium;

namespace Animatronio.WebDriver
{
    /// <summary>
    /// Frame represents an IFrame on the page.  It is passed into an Element class to support
    /// automatically selecting the appropriate iframe before an element is found.
    /// </summary>
    public class Frame : Element
    {
        public Frame(By by) : base(by)
        {

        }
    }
}
