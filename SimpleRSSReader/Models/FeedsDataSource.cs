using Microsoft.Toolkit.Parsers.Rss;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;


namespace SimpleRSSReader.Models
{
    public static class FeedsDataSource
    {

        public static async Task<bool> GetFeedAsync(Feed feedModel)
        {
            string feed = null;
            using(var client = new HttpClient())
            {
                try
                {
                    feed = await client.GetStringAsync(feedModel.Link);
                }
                catch
                {
                    return false;
                }

                if(feed!=null)
                {
                    var parser = new RssParser();
                    var rss = parser.Parse(feed);
                    
                    foreach(var element in rss)
                    {
                        Article newArticle = new Article();
                        newArticle.Title = element.Title;
                        newArticle.Summary = element.Summary;
                        newArticle.PublishedDate = element.PublishDate;
                        newArticle.Link = new Uri(element.FeedUrl);
                        feedModel.Articles.Add(newArticle);
                        feedModel.LastSyncDate = DateTime.Now;
                        Console.WriteLine(element.FeedUrl);
                    }
                }
            }
            return true;
        }
    }
}
