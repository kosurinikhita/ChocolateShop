using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChocolateShop.entity;
using ChocolateShop.Models;
using ChocolateShop.DAL;

namespace ChocolateShop.DAL
{
    public class ChocolateRepository
    {
        ChocolateRepository chocolateRepository = new ChocolateRepository();
        public static List<Chocolate> chocolate = new List<Chocolate>();
        
        public void AddChocolate(Chocolate chocolates)
        {
            using (AccountContext db = new AccountContext())
            {
                db.Chocolate.Add(chocolates);
                db.SaveChanges();
            }
            
        }
        public List<Chocolate> GetChocolateDetails()
        {
            using (AccountContext accountContext = new AccountContext())
            {
                List<Chocolate> data = accountContext.Chocolate.ToList();
                return data;
            }
        }

        public void DeleteChocolate(string Name)
        {
            using (AccountContext db = new AccountContext())
            {
                Chocolate chocolate = db.Chocolate.Find(Name);
                db.Chocolate.Remove(chocolate);
                db.SaveChanges();
            }
        }
        public void UpdateChocolate(Chocolate chocolate)
        {
            using (AccountContext db = new AccountContext())
            {
                db.Entry(chocolate).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        public Chocolate GetChocolate(string Name)
        {
            using(AccountContext accountContext = new AccountContext())
            {
                return accountContext.Chocolate.Where(chocolate => chocolate.Name == Name).FirstOrDefault();
            }
        }

       
        
    }
}
