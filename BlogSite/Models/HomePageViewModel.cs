using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BlogSite.Data;

namespace BlogSite.Models
{
    public class HomePageViewModel
    {
        public IEnumerable<BlogPost> Posts { get; set; }
        public int? NextPage { get; set; }
        public int? PreviousPage { get; set; }
    }
}