using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Blog.WebUI.Models
{
    public class ArticleContentModel
    {
        [Required(ErrorMessage = "Enter your title")]
        [DisplayName("Title:")]
        public String Title { set; get; }

        [Required(ErrorMessage = "What can you tell us?")]
        [DisplayName("Content:")]
        public String Content { set; get; }

        [Required(ErrorMessage = "Describe your topic briefly")]
        [DisplayName("Short Content:")]
        public String ShortContent { set; get; }
    }
}