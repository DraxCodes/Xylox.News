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
            _news = new List<XyloxNews> { new XyloxNews("Base News Item") };
        }

        public void Add(XyloxNews item)
        {
            _news.Add(item);
        }

        public IEnumerable<XyloxNews> Get()
        {
            return _news;
        }
    }
}
