using System;
using System.Collections.Generic;
using System.Text;
using Entities.Models;

namespace Entities.Extensions
{
    public static class AccountExtensions
    {
        public static void Map(this Account dbAccount, Account owner)
        {
            dbAccount.AccountType = owner.AccountType;
            dbAccount.DateCreated = owner.DateCreated;
            dbAccount.OwnerId = owner.OwnerId;
        }
    }
}
