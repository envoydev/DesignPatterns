using Observer.News;
using Observer.Wigets;

namespace Observer
{
    class Program
    {
        //Main idea of Observe pattern is to notify of followers(subscribes, other classes who subscibed) 
        //about changes of main observable class. The observable class shoul have method that shows changes
        //and mehtod implemented method to notify followers about the changes and show this changes

        static void Main(string[] args)
        {
            //Create newsObserve object
            NewsAggregator newsObserve = new NewsAggregator();
            //Add some news
            newsObserve.AddNews("facebook", "some new news for facebook");
            newsObserve.AddNews("twitter", "some new news for twitter");
            newsObserve.AddNews("pinterest", "some new news for pinterest");

            //Create wiget objects and register this objects in Observable
            FacebookWiget facebook = new FacebookWiget(newsObserve);
            TwitterWiget twitter = new TwitterWiget(newsObserve);
            Pinterest pinterest = new Pinterest(newsObserve);

            //view facebook, twitter and pinterest news
            newsObserve.NotifyObserver();
            //remove twitter wiget from collection
            newsObserve.RemoveObserver(twitter);
            //view only facebook and pintertest news
            newsObserve.NotifyObserver();
        }
    }
}
