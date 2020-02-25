using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Account.entity
{
    public class Account
    {
        //[Required(ErrorMessage = "Name Required")]
        [Required]
        public string Name { get; set; }
        //[Required(ErrorMessage = "Password Required")]
        [Required]
        public string Password { get; set; }
        // [Required(ErrorMessage = "Email Required")]
        // [RegularExpression(" ^[a - zA - Z0 - 9_\\.-] +@([a - zA - Z0 - 9 -] +\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "Not Valid EmailId")]
        [Required]
        public string Email { get; set; }
        //[Required(ErrorMessage = "Gender Required")]
        [Required]
        public string Gender { get; set; }
        //[Required(ErrorMessage = "City Required")]
        [Required]
        public string City { get; set; }

    }
}
