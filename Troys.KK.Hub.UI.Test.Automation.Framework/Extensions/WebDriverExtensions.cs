using OpenQA.Selenium;

namespace Troys.KK.Hub.UI.Test.Automation.Framework.Extensions
{
    public static class WebDriverExtensions
    {
        public static void NavigateToUrl(this IWebDriver webDriver, string pageUrl)
        {
            webDriver.Navigate().GoToUrl(pageUrl);
        }
    }
}
