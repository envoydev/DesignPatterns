using System.Collections.Generic;

namespace Observer.News.Interface
{
    public interface INews
    {
        void AddNews(string key, string value);
        IDictionary<string, string> GetNews();
    }
}
