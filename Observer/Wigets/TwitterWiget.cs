using Observer.BaseObserver;
using Observer.News;
using Observer.Wigets.Interface;
using System;

namespace Observer.Wigets
{
    class TwitterWiget : IObserver, IWiget
    {
        private const string twitter = "twitter";

        private readonly NewsAggregator _newsAggregator;
        private string _news;

        public TwitterWiget(NewsAggregator newsAggregator)
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
            var twitterNews = _newsAggregator.GetNews()[twitter];
            if (twitterNews != null)
            {
                _news = twitterNews;
                Display();
            }
        }
    }
}
