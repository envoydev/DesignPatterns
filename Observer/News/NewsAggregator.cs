using Observer.BaseObserver;
using Observer.News.Interface;
using System;
using System.Collections.Generic;

namespace Observer.News
{
    public class NewsAggregator : ISubject, INews
    {
        private IList<IObserver> _observers;
        private IDictionary<string, string> _news;

        public NewsAggregator()
        {
            _observers = new List<IObserver>();
            _news = new Dictionary<string, string>();
        }

        public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObserver()
        {
            foreach (var observer in _observers)
            {
                observer.Update();
            }
            Console.WriteLine();
        }

        public void AddNews(string key, string value)
        {
            _news.Add(key, value);
        }

        public IDictionary<string, string> GetNews()
        {
            return _news;
        }


    }
}
