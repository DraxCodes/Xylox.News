using System.Collections.Generic;
using Xylox.News.Entities;

namespace Xylox.News.Storage
{
    public interface IDataStore
    {
        IEnumerable<XyloxNews> Get();
        void Add(XyloxNews item);
    }
}
