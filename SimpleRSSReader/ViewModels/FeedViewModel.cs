using RssReader.Common;
using SimpleRSSReader.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRSSReader.ViewModels
{
    class FeedViewModel : BindableBase
    {
        public FeedViewModel()
        {
            //webBrowser.Navigate("https://visualstudiomagazine.com/articles/2020/08/27/blazor-updates.aspx");
        }
        public ObservableCollection<Article> AllArticles { get; set; }
    }
}
