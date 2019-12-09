using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Entities;
using Api.Domain.Interfaces;
using Api.Domain.Interfaces.Services.User;

namespace Api.Service.Services
{
    public class AccountService : IAccountService
    {
        private IRepository<AccountEntity> _repository;
        public AccountService(IRepository<AccountEntity> repository)
        {
            _repository = repository;

        }
        public async Task<AccountEntity> Post(AccountEntity account)
        {
            return await _repository.InsertAsync(account);
        }

    }
}
