using System;
using TechTalk.SpecFlow;

namespace Troys.KF.Hub.UI.Test.Specs.Steps
{
    [Binding]
    public sealed class DatabaseInjectionSteps
    {


        private readonly ScenarioContext context;
        private readonly ContactService contactService;
        private readonly HubRepository hubRepository;

        public DatabaseInjectionSteps(ScenarioContext context,
            ContactService contactService,
            HubRepository hubRepository)
        {
            this.context = context;
            this.contactService = contactService;
            this.hubRepository = hubRepository;
        }

        [Given(@"a count of all active contacts exists")]
        public void GivenACountOfAllActiveContactsExists()
        {
            //var contactSearchResult = new SearchResult
            //{
            //    TotalCount = "1457702"
            //};




            var seedContact = this.contactService.GenerateSeedContact(x => { x.Id = new Guid("9245fe4a-d402-451c-b9ed-9c1a04247482"); });

            var contactSearchResult = this.hubRepository.ContactSearchResult();

            this.context.Set(contactSearchResult);

            //this.newContactPage.EnterMandatoryData(seedContact);
        }

    }
}
