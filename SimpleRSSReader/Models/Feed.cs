using RssReader.Common;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRSSReader.Models
{
    public class Feed : BindableBase
    {
        public Feed()
        {
            Articles = new ObservableCollection<Article>();
        }
        public Uri Link
        {
            get; set;
        }
        private Uri _link;
        public string Name
        {
            get;
            set;
        }
        private string _name;
        public string Description
        {
            get;
            set;
        }
        public DateTime LastSyncDate { get; set; }
        public ObservableCollection<Article> Articles { get; }
    }
}
