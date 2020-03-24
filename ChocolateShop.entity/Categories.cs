using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocolateShop.entity
{
    [Table("Categories")]
    public class Categories
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CategorieId { get; set; }
        [Required(ErrorMessage = "Name Required")]
        [RegularExpression(@"^(([A-za-z]+[\s]{1}[A-za-z]+)|([A-Za-z]+))$", ErrorMessage = "Please enter valid username")]
        public string Name { get; set; }
        public Categories(Categories categories)
        {
            CategorieId = categories.CategorieId;
            Name = categories.Name;
        }

        public Categories()
        {

        }
    }
}
