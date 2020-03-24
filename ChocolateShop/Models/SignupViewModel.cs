using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ChocolateShop.Models
{
    public class SignupViewModel
    {
        //[Key]
        public int UserId { get; set; }
        [Required(ErrorMessage = "Name Required")]
        [RegularExpression(@"^(([A-za-z]+[\s]{1}[A-za-z]+)|([A-Za-z]+))$", ErrorMessage = "Please enter valid username")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Password Required")]
        [RegularExpression(@"^.*(?=.{8,})(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[!*@#$%^&+=]).*$", ErrorMessage = @"Eg:User@123")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Email Required")]
        //[RegularExpression(" ^[a - zA - Z0 - 9_\\.-] +@([a - zA - Z0 - 9 -] +\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "Not Valid EmailId")]
        //[Required]
        public string Email { get; set; }
        [Required(ErrorMessage = "Gender Required")]
        //[Required]
        public string Gender { get; set; }
        [Required(ErrorMessage = "City Required")]
        //[Required]
        public string City { get; set; }

    }
}