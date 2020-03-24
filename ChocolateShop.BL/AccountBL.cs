using ChocolateShop.DAL;
using ChocolateShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocolateShop.BL
{
    public class AccountBL
    {
        
        public void Signup(AccountEntity accountentity)
        {
            //AccountRepository accountRepository = new AccountRepository();
            AccountRepository.Signup(accountentity);
        }
        public AccountEntity Login(AccountEntity accountentity)
        {
            AccountRepository accountRepository = new AccountRepository();
            return accountRepository.Login(accountentity);
        }
    }
}
