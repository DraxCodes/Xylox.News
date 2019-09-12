using System;
using System.Collections.Generic;
using Xylox.News.Entities;

namespace Xylox.News.Storage
{
    public class NewsStorage : IDataStore
    {
        private List<XyloxNews> _news;

        public NewsStorage()
        {
            _news = new List<XyloxNews> { new XyloxNews {
                Title = "Base Title",
                Description = "Base Description"
             }};
        }

        public void Add(XyloxNews item)
        {
            _news.Add(item);
        }

        public IEnumerable<IDataStoreItem> Get()
        {
            return _news;
        }
    }
}
