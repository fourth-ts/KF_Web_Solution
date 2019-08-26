using System;

namespace Troys.KK.Hub.UI.Test.Automation.Framework.Services
{
    public class ContactService
    {
        private readonly ContactsSeedGenerator contactsSeedGenerator;

        public ContactService(ContactsSeedGenerator contactsSeedGenerator)
        {
            this.contactsSeedGenerator = contactsSeedGenerator;
        }

        public Contact GenerateSeedContact(Action<Contact> overrides = null)
        {
            Contact seedContact = this.contactsSeedGenerator.Generate();


            overrides?.Invoke(seedContact);
            //this.scenarioContext.Set(seedContact);

            return seedContact;
        }
    }
}
