using System;

namespace Xylox.News.Entities
{
    public class XyloxNews : IDataStoreItem
    {
        public Guid Id { get; } = Guid.NewGuid();

        public string Title { get; set; }
        public string Description { get; set; }

        public XyloxNews() { }

        public XyloxNews(string title)
        {
            Title = title;
        }

        public XyloxNews(string title, string description)
        {
            Title = title;
            Description = description;
        }
    }
}
