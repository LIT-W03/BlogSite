using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BlogSite.Data;

namespace BlogSite.Models
{
    public class ViewBlogViewModel
    {
        public BlogPost Post { get; set; }
        public IEnumerable<Comment> Comments { get; set; }
        public string CommenterName { get; set; }
    }
}