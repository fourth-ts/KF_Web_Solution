using Troys.KK.Hub.UI.Test.Automation.Framework.DbAccess.DataModels;

namespace Troys.KK.Hub.UI.Test.Automation.Framework.Repositories
{

    public class HubRepository
    {
        private readonly ContactRepository contactRepository;

        public HubRepository(ContactRepository contactRepository)
        {
            this.contactRepository = contactRepository;
        }

        public SearchResult ContactSearchResult()
        {
            SearchResult contactTotalResult = this.contactRepository.GetTotalActiveContacts<SearchResult>();
            return contactTotalResult;
        }
    }
}
