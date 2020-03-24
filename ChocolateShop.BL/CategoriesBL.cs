using ChocolateShop.DAL;
using ChocolateShop.Models;
using ChocolateShop.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocolateShop.BL
{
    public class CategoriesBL
    {

        CategoriesRepository categoriesRepository = new CategoriesRepository();
        public void AddCategories(Categories categories)
        {
            categoriesRepository.AddCategories(categories);
        }
        public void UpdateCategories(Categories categories)
        {
            categoriesRepository.UpdateCategories(categories);
        }
        public void DeleteCategories(int Id)
        {
            categoriesRepository.DeleteCategories(Id);
        }
        public void GetCategories(string Name)
        {
            categoriesRepository.GetCategories(Name);
        }
        public List<Categories> GetCategoriesDetails()
        {
            return categoriesRepository.GetCategoriesDetails();
        }
    }
}
