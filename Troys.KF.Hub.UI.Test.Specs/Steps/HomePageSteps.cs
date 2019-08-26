using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using Troys.KK.Hub.UI.Test.Automation.Framework.Enums;
using Troys.KK.Hub.UI.Test.Automation.Framework.Pages;

namespace Troys.KF.Hub.UI.Test.Specs.Steps
{
    [Binding]
    public sealed class HomePageSteps
    {
        private readonly HomePage homePage;

        public HomePageSteps(HomePage homePage)
        {
            this.homePage = homePage;
        }

        [Given(@"hub is displayed")]
        public void GivenHubIsDisplayed()
        {
            this.homePage.Launch();
        }

        [When(@"I search for all contacts")]
        public void WhenISearchForAllContacts()
        {
            this.homePage.SearchContacts(SearchType.All);
        }


    }
}
