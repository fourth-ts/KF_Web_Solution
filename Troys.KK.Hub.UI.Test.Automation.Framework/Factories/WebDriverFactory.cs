using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Troys.KK.Hub.UI.Test.Automation.Framework.Factories
{
    public class WebDriverFactory
    {

        public static IWebDriver Create()
        {
            var webDriver = new ChromeDriver();
            webDriver.Manage().Window.Maximize();
            return webDriver;
        }
    }
}
