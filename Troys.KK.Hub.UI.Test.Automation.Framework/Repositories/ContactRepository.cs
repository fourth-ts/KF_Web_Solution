using System;
using System.Collections.Generic;
using Troys.KK.Hub.UI.Test.Automation.Framework.Interfaces;

namespace Troys.KK.Hub.UI.Test.Automation.Framework.Repositories
{

    public class ContactRepository : IRepository<Contact>
    {
        private readonly HubDbContext dbContext;

        public ContactRepository(HubDbContext hubDbContext)
        {
            this.dbContext = hubDbContext();
        }

        public void SingleInsert(Contact item)
        {
            this.dbContext.Contact.Add(item);
            this.dbContext.SaveChanges();
        }

        public T GetTotalActiveContacts<T>()
        {
            throw new NotImplementedException();
        }

        public void BulkInsert(IList<Contact> list)
        {
            this.dbContext.Contact.AddRange(list);
            this.dbContext.SaveChanges();
        }

        public void DeleteSingle(Contact item)
        {
            this.dbContext.Contact.Remove(item);
            this.dbContext.SaveChanges();
        }

        public void DeleteAll(IList<Contact> list)
        {
            this.dbContext.Contact.RemoveRange(list);
            this.dbContext.SaveChanges();
        }

    }
}
