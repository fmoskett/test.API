using System.Collections.Generic;
using System.Threading.Tasks;
using Test.API.Domain.Models;

namespace Test.API.Domain.Repositories
{
    public interface IOrdersRepository
    {
        Task<IEnumerable<Orders>> ListAsync();
        Task AddAsync(Orders order);
        Task<Orders> FindByIdAsync(int id);
        void Update(Orders order);
        void Remove(Orders order);
    }
}