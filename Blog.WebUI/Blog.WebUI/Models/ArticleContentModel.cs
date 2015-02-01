using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Blog.WebUI.Models
{
    public class ArticleContentModel
    {
        public String Title { set; get; }
        public String Content { set; get; }
        public String ShortContent { set; get; }
    }
}