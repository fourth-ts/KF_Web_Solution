using OpenQA.Selenium;

namespace Troys.KK.Hub.UI.Test.Automation.Framework.Pages
{
    public class SearchResultsPage
    {
        private readonly IWebDriver webDriver;

        public SearchResultsPage(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
        }

        public string TotalSearchResults()
        {
            var webElement = this.webDriver.FindElement(By.CssSelector(".search-label.margin-right-20 span[2]"));
            return webElement.Text;
        }
    }
}
