using SimpleRSSReader.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Web.WebView2.Core;

namespace SimpleRSSReader.Views
{
    /// <summary>
    /// Interaction logic for FeedView.xaml
    /// </summary>
    public partial class FeedView : UserControl
    {
        public FeedView()
        {
            InitializeComponent();
            //articlesLst.SelectionChanged += LstOnSelectionChanged;
        }

        void LstOnSelectionChanged(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Triggered");
            Article article = ((ListViewItem)sender).Content as Article;
            if(article == null)
            {
                return;
            }
            else
            {
                MessageBox.Show("Time to order more copies of " + article.Link.ToString());
                Console.WriteLine(article.Title);
            }
        }

        private void LstOnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (webView != null && webView.CoreWebView2 != null)
            {
                webView.CoreWebView2.Navigate(((Article)articlesLst.SelectedItem).Link.ToString());
            }
            //MessageBox.Show(((Article)articlesLst.SelectedItem).Link.ToString());

        }
    }
}
