using System;
using System.Collections.Generic;
using System.Linq;
using Contracts;
using Entities;
using Entities.ExtendedModels;
using Entities.Extensions;
using Entities.Models;

namespace Repository
{
    public class AccountRepository : RepositoryBase<Account>, IAccountRepository
    {
        public AccountRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }

        public IEnumerable<Account> GetAllAccounts()
        {
            return FindAll()
                .OrderBy(ac => ac.AccountType);
        }

        public Account GetAccountById(Guid accountId)
        {
            return FindByCondition(account => account.Id.Equals(accountId))
                    .DefaultIfEmpty(new Account())
                    .FirstOrDefault();
        }

        public AccountExtended GetAccountWithDetails(Guid accountId)
        {
            Account account = GetAccountById(accountId);
            return new AccountExtended(account)
            {
                Owners = RepositoryContext.Owners
                    .Where(o => o.Id == account.OwnerId)
            };
        }

        public void CreateAccount(Account account)
        {
            account.Id = Guid.NewGuid();
            Create(account);
            Save();
        }

        public void UpdateAccount(Account dbAccount, Account account)
        {
            dbAccount.Map(account);
            Update(dbAccount);
            Save();
        }

        public void DeleteAccount(Account account)
        {
            Delete(account);
            Save();
        }
    }
}