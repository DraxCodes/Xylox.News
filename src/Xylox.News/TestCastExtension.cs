using System.Collections.Generic;
using Xylox.News.Entities;

namespace Xylox.News
{
    public static class TestCastExtension
    {
        public static IEnumerable<T> CastTo<T>(this IEnumerable<IDataStoreItem> collection) where T : IDataStoreItem
        {
            var result = new List<T>();

            foreach (var item in collection)
            {
                result.Add((T)item);
            }

            return result;
        }
    }
}
