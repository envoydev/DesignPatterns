using Observer.BaseObserver;
using Observer.News;
using Observer.Wigets.Interface;
using System;

namespace Observer.Wigets
{
    public class Pinterest : IObserver, IWiget
    {
        private const string pinterest = "pinterest";

        private readonly NewsAggregator _newsAggregator;
        private string _news;

        public Pinterest(NewsAggregator newsAggregator)
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
            var pinterestNews = _newsAggregator.GetNews()[pinterest];
            if (pinterestNews != null)
            {
                _news = pinterestNews;
                Display();
            }
        }
    }
}
