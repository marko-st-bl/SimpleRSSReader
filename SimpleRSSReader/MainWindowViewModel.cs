using RssReader.Common;
using SimpleRSSReader.Models;
using SimpleRSSReader.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRSSReader
{
    class MainWindowViewModel : BindableBase
    {
        public MainWindowViewModel()
        {
            Articles = new ObservableCollection<Article>();
            CurrentViewModel = feedViewModel;
            Feed feed = new Feed();
            feed.Link = new Uri("https://visualstudiomagazine.com/rss-feeds/news.aspx");
            FeedsDataSource.GetFeedAsync(feed);
            feedViewModel.AllArticles = feed.Articles;
            
        }
        private FeedViewModel feedViewModel = new FeedViewModel();
        public ObservableCollection<Article> Articles { get; set; }
        public BindableBase CurrentViewModel { get; set; }
    }
}
