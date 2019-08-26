using OpenQA.Selenium;
using System;
using Troys.KK.Hub.UI.Test.Automation.Framework.Enums;
using Troys.KK.Hub.UI.Test.Automation.Framework.Extensions;

namespace Troys.KK.Hub.UI.Test.Automation.Framework.Pages
{

    public class HomePage
    {
        private readonly IWebDriver webDriver;
        private readonly ContactsPage contactsPage;

        public HomePage(IWebDriver webDriver,
            ContactsPage contactsPage)
        {
            this.webDriver = webDriver;
            this.contactsPage = contactsPage;
        }

        public void Launch()
        {
            this.webDriver.NavigateToUrl("http://thedemosite.co.uk/login.php");
        }

        public void SearchContacts(SearchType searchType)
        {
            SearchContacts();
            Search(searchType);
            ClickSubmit();

        }

        private void ClickSubmit()
        {
            var webElement = this.webDriver.FindElement(By.CssSelector("button.search-button"));
            webElement.Click();
        }

        private void Search(SearchType searchType)
        {
            switch (searchType)
            {
                case SearchType.All:
                    this.contactsPage.ClickAll();
                    break;
                default:
                    throw new ArgumentException("Invalid Search Type. Enter a valid search type OR implement new case");
            }
        }

        private void SearchContacts()
        {
            var webElement = this.webDriver.FindElement(By.LinkText("Contacts"));
            webElement.Click();
        }
    }
}
