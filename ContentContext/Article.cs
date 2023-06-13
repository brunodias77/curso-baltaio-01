using System;
using Balta.NotificationContext;

namespace Balta.ContentContext
{
    public class Article : Content
    {
        public Article(string title, string url) : base(title, url)
        {


        }
        public IList<Notification> Notications { get; set; }
    }
}

