using ChocolateShop.entity;
using ChocolateShop.Models;
using System;
using System.Data.Entity;

namespace ChocolateShop.DAL
{
    public class AccountContext:DbContext
    {
        // public AccountContext() : base("AccountContext") { }
        public  DbSet<AccountEntity> Account { get; set; }
        public DbSet<Chocolate> Chocolate { get; set; }
        public DbSet<Categories> Categories { get; set; }

        //public void SaveChanges()
        //{
        //    throw new NotImplementedException();
        //}

    }
}
