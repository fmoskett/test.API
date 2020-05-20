using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Test.API.Domain.Models;
using Test.API.Domain.Repositories;
using Test.API.Persistence.Contexts;

namespace Test.API.Persistence.Repositories
{
    public class OrdersRepository : BaseRepository, IOrdersRepository
    {
        public OrdersRepository(AppDbContext context) : base(context)
        { }

        public async Task AddAsync(Orders order)
        {
            await _context.Orders.AddAsync(order);
        }

        public async Task<Orders> FindByIdAsync(int id)
        {
            return await _context.Orders.FindAsync(id);
        }

        public async Task<IEnumerable<Orders>> ListAsync()
        {
            return await _context.Orders.ToListAsync();
    }

        public void Remove(Orders order)
        {
            _context.Orders.Remove(order);
        }

        public void Update(Orders order)
        {
            _context.Orders.Update(order);
        }     
    }
}