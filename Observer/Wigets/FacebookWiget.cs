using Observer.BaseObserver;
using Observer.News;
using Observer.Wigets.Interface;
using System;
using System.Collections.Generic;

namespace Observer.Wigets
{
    public class FacebookWiget : IObserver, IWiget
    {
        private const string facebook = "facebook";

        private readonly NewsAggregator _newsAggregator;
        private string _news;

        public FacebookWiget(NewsAggregator newsAggregator)
        {
            newsAggregator.RegisterObserver(this);
            _newsAggregator = newsAggregator;
        }

        public void Display()
        {
            Console.WriteLine(_news);
        }

        public void Update()
        {
            var facebookNews = _newsAggregator.GetNews()[facebook];
            if (facebookNews != null)
            {
                _news = facebookNews;
                Display();
            }
        }
    }
}
