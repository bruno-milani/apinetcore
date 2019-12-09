using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Entities;

namespace Api.Domain.Interfaces.Services.User
{
    public interface IAccountService
    {
        Task<AccountEntity> Post(AccountEntity user);

    }
}
