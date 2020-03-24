using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ChocolateShop.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Name Required")]
        [RegularExpression(@"^(([A-za-z]+[\s]{1}[A-za-z]+)|([A-Za-z]+))$", ErrorMessage = "Please enter valid username")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Password Required")]
        public string Password { get; set; }
    }
}