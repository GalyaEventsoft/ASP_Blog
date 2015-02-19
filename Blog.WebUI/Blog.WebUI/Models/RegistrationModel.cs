using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Blog.WebUI.Models
{
    public class RegistrationModel
    {
        [Required(ErrorMessage = "Please, enter your name")]
        [DisplayName("Name:")]
        [RegularExpression("^[а-яА-ЯёЁa-zA-Z]+$", ErrorMessage = "Your name should consists only from letters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please, enter login")]
        [DisplayName("Login:")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Please, enter password")]
        [DisplayName("Password:")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please, confirm the password")]
        [DisplayName("Confirm password:")]
        public string ConfirmPassword { get; set; }
    }
}