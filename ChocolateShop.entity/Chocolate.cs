using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ChocolateShop.entity
{
    public class Chocolate
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ChocolateId { get; set; }
        [Required]
        [RegularExpression(@"^(([A-za-z]+[\s]{1}[A-za-z]+)|([A-Za-z]+))$", ErrorMessage = "Please enter valid username")]
        [Display(Name = "Chocolate Name")]
        public string Name { get; set; }
        [Required]
        [RegularExpression(@"^(([A-za-z]+[\s]{1}[A-za-z]+)|([A-Za-z]+))$", ErrorMessage = "Please enter valid username")]
        public string Company { get; set; }
        [Required]
        [Range(0, 1000)]
        public int Quantity { get; set; }
       // public DateTime ManufactureDate { get; set; }
        //public DateTime ExpiryDate { get; set;}
        [Required]
        [Range(0, 1000)]
        public int Price { get; set; }
        [Required]
        [RegularExpression(@"^(([A-za-z]+[\s]{1}[A-za-z]+)|([A-Za-z]+))$", ErrorMessage = "Please enter valid username")]
        public string Description { get; set; }
        public Categories CategorieId { get; set; }
       // public int CategorieId { get; set; }

        public Chocolate(Chocolate chocolate)
        {
            ChocolateId = chocolate.ChocolateId;
            Name = chocolate.Name;
            Price = chocolate.Price;
            Company = chocolate.Company;
            Quantity = chocolate.Quantity;
            //ManufactureDate = chocolate.ManufactureDate;
            //ExpiryDate = chocolate.ExpiryDate;
            Description = chocolate.Description;
        }
        public Chocolate()
        {

        }
    }
}
