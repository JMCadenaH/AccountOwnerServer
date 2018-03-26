using System;
using System.Collections.Generic;
using Entities.ExtendedModels;
using Entities.Models;

namespace Contracts
{
    public interface IAccountRepository : IRepositoryBase<Account>
    {
        IEnumerable<Account> GetAllAccounts();
        Account GetAccountById(Guid accountId);
        AccountExtended GetAccountWithDetails(Guid accountId);
        void CreateAccount(Account account);
        void UpdateAccount(Account dbAccount, Account account);
        void DeleteAccount(Account account);
    }
}