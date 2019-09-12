using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Xylox.News.Entities
{
    public class XyloxNews
    {
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
