using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using ChocolateShop.entity;
using ChocolateShop.Models;
using ChocolateShop.DAL;


namespace ChocolateShop.DAL
{
   
    public class AccountRepository
    {
        public AccountEntity Login(AccountEntity accountentity)
        {
            throw new NotImplementedException();
        }
        public  static void Signup(AccountEntity accountentity)
        {
            using (AccountContext accountContext = new AccountContext())
            {
                accountContext.Account.Add(accountentity);
                accountContext.SaveChanges();

            }


        }
        public static AccountEntity ValidateUser(AccountEntity account)
        {
            AccountContext database = new AccountContext();
            AccountEntity result= database.Account.Where(user => user.Name == account.Name && user.Password == account.Password).FirstOrDefault();
            return result;
        }
        //public IEnumerable<Account> GetAccountDetails()
        //{
        //    return account;
        //}
    }
}
