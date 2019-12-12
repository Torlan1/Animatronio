using System;
using Animatronio.Settings;
using OpenQA.Selenium;

namespace Animatronio.WebDriver
{
    /// <summary>
    /// BasePageObject is an abstract class to be inherited by all page objects
    /// It provides a logger, root uri, and extends the element class
    /// It can be built using a By locator that becomes the root container for the class
    /// </summary>
    public abstract class BasePageObject : Element
    {
        public string Uri;
        public string Domain;

        /// <summary>
        /// Instantiate a page object without a root container element.  
        /// </summary>
        public BasePageObject() : base()
        {
        }

        /// <summary>
        /// instntiates a page object using a by locator.  The by locator bedcomes an element container
        /// that represenets the root element in the dom for this page object.
        /// </summary>
        /// <param name="by"></param>
        public BasePageObject(By by) : base(by)
        {
        }

        /// <summary>
        /// Instantiate a page object inside an IFrame, with a By locator that becomes the
        /// root element for the page object
        /// </summary>
        /// <param name="frame"></param>
        /// <param name="by"></param>
        public BasePageObject(Frame frame, By by) : base(frame, by)
        {
        }

        /// <summary>
        /// Instantiates a page object using another page object as a root container, and a by locator
        /// </summary>
        /// <param name="container"></param>
        /// <param name="by"></param>
        public BasePageObject(BasePageObject container, By by) : base(container, by)
        {
        }

        /// <summary>
        /// Instntiate a page object using a container, an iframe, and a by locator.
        /// </summary>
        /// <param name="container"></param>
        /// <param name="frame"></param>
        /// <param name="by"></param>
        public BasePageObject(BasePageObject container, Frame frame, By by) : base(container, frame, by)
        {
        }
    }
}