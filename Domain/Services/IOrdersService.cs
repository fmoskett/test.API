using System.Collections.Generic;
using System.Threading.Tasks;
using Test.API.Domain.Models;

namespace Test.API.Domain.Services
{
    public interface IOrdersService
    {
         Task<IEnumerable<Orders>> ListAsync();
    }
}