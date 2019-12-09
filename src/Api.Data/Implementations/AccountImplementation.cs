using System.Threading.Tasks;
using Api.Data.Context;
using Api.Data.Repository;
using Api.Domain.Entities;
using Api.Domain.Repository;
using Microsoft.EntityFrameworkCore;

namespace Api.Data.Implementations
{
    public class AccountImplementation : BaseRepository<AccountEntity>, IAccountRepository
    {
        private DbSet<AccountEntity> _datasetAccount;
        public AccountImplementation(MyContext context) : base(context)
        {
            _datasetAccount = context.Set<AccountEntity>();
        }
        public async Task<AccountEntity> FindByNumber(string number)
        {
            return await _datasetAccount.FirstOrDefaultAsync(a => a.AccountNumber.Equals(number));
        }
    }
}
