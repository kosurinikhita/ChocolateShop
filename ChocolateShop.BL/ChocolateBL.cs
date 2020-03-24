using ChocolateShop.DAL;
using ChocolateShop.entity;
using ChocolateShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocolateShop.BL
{
    
    public class ChocolateBL 
    {
        ChocolateRepository chocolateRepository = new ChocolateRepository();
        public void AddChocolate(Chocolate chocolate)
        {
            chocolateRepository.AddChocolate(chocolate);
        }
        public void UpdateChocolate(Chocolate chocolate)
        {
            chocolateRepository.UpdateChocolate(chocolate);
        }
        public void DeleteChocolate(string Name)
        {
            chocolateRepository.DeleteChocolate(Name);
        }
        public void GetChocolate(string Name)
        {
            chocolateRepository.GetChocolate(Name);
        }
        public List<Chocolate> GetChocolateDetails()
        {
            return chocolateRepository.GetChocolateDetails();
        }
        public List<Categories> DownDrop()
        {
            return CategoriesRepository.DropDownList();
        }

    }
}
