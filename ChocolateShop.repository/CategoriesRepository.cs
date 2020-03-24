using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChocolateShop.entity;

namespace ChocolateShop.DAL
{
    public class CategoriesRepository
    {
        public static List<Categories> categories = new List<Categories>();
        public void AddCategories(Categories categorie)
        {
            using (AccountContext db = new AccountContext())
            {
                db.Categories.Add(categorie);
                db.SaveChanges();
            }
        }

        public List<Categories> GetCategoriesDetails()
        {
            using (AccountContext accountContext = new AccountContext())
            {
                List<Categories> data = accountContext.Categories.ToList();
                return data;
            }
        }
        
        public void DeleteCategories(int id)
        {
            using (AccountContext db = new AccountContext())
            {
                Categories categories = db.Categories.Find(id);
                db.Categories.Remove(categories);
                db.SaveChanges();
            }
        }

        public static List<Categories> DropDownList()
        {
            using (AccountContext accountContext = new AccountContext())
            {
                List<Categories> data = accountContext.Categories.ToList();
                return data;
            }
        }

        public void UpdateCategories(Categories categories)
        {
            using (AccountContext db = new AccountContext())
            {               
                db.Entry(categories).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        public Categories GetCategories(string Name)
        {
            using (AccountContext accountContext = new AccountContext())
            {
                return accountContext.Categories.Where(categories => categories.Name == Name).FirstOrDefault();
            }
        }
    }
}

