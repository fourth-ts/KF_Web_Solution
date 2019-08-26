using NUnit.Framework;
using TechTalk.SpecFlow;
using Troys.KK.Hub.UI.Test.Automation.Framework.DbAccess.DataModels;
using Troys.KK.Hub.UI.Test.Automation.Framework.Pages;

namespace Troys.KF.Hub.UI.Test.Specs.Steps
{
    [Binding]
    public sealed class SearchResultSteps
    {
        private readonly ScenarioContext context;
        private readonly SearchResultsPage searchResultsPage;

        public SearchResultSteps(ScenarioContext context, SearchResultsPage searchResultsPage)
        {
            this.context = context;
            this.searchResultsPage = searchResultsPage;
        }

        [Then(@"all active contacts are displayed")]
        public void ThenAllActiveContactsAreDisplayed()
        {
            string expectedTotalResult = this.context.Get<SearchResult>().TotalCount;
            string actualTotalResult = this.searchResultsPage.TotalSearchResults();

            Assert.AreEqual(expectedTotalResult, actualTotalResult, "Actual total active contacts NOT expected");
        }

    }
}
