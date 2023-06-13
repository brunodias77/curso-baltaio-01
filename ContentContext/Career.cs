﻿using System;
namespace Balta.ContentContext
{
    public class Career : Content
    {
        public Career(string title, string url) : base(title, url)
        {
            Items = new List<CareerItem>();
        }
        public IList<CareerItem> Items { get; set; }
        // Expression body
        //public int TotalCourses => Items.Count;
        public int TotalCourses
        {
            get
            {
                return Items.Count;
            }
        }

 
    }


}

