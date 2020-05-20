using System.Collections.Generic;
using System.Threading.Tasks;
using Test.API.Domain.Models;
using Test.API.Domain.Repositories;
using Test.API.Domain.Services;

namespace Test.API.Services
{
    public class OrderService : IOrdersService
    {
        private readonly IOrdersRepository _orderRepository;
        public OrderService(IOrdersRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public async Task<IEnumerable<Orders>> ListAsync()
        {
            return await _orderRepository.ListAsync();
        }
    }
}