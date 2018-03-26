using System;
using System.Collections.Generic;
using System.Text;
using Entities.Models;

namespace Entities.ExtendedModels
{
    public class AccountExtended : IEntity
    {
        public Guid Id { get; set; }
        public string AccountType { get; set; }
        public DateTime DateCreated { get; set; }
        public Guid OwnerId { get; set; }

        public IEnumerable<Owner> Owners { get; set; }

        public AccountExtended()
        {
        }

        public AccountExtended(Account account)
        {
            Id = account.Id;
            AccountType = account.AccountType;
            DateCreated = account.DateCreated;
            OwnerId = account.OwnerId;
        }
    }
}
