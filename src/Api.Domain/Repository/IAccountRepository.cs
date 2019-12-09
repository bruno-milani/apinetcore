using System.Threading.Tasks;
using Api.Domain.Entities;
using Api.Domain.Interfaces;

namespace Api.Domain.Repository
{
    public interface IAccountRepository : IRepository<AccountEntity>
    {
        Task<AccountEntity> FindByNumber(string number);
    }
}
