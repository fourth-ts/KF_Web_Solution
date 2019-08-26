using System.Collections.Generic;

namespace Troys.KK.Hub.UI.Test.Automation.Framework.Interfaces
{
    public interface IRepository<T>
    {
        void SingleInsert(T item);

        void BulkInsert(IList<T> list);

        void DeleteSingle(T item);

        void DeleteAll(IList<T> list);
    }
}
