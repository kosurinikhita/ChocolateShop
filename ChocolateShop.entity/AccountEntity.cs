using System; 
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChocolateShop.Models
{
    public class AccountEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }
        public string Name { get; set; }   
        public string Password { get; set; }   
        public string Email { get; set; } 
        public string Gender { get; set; }
        public string City { get; set; }

        }
    }