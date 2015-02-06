using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Blog.WebUI.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Who are you?")]
        [DisplayName("User login:")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Where is your password?")]
        [DisplayName("Password:")]
        public string Password { get; set; }
    }
}