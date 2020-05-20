using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Test.API.Domain.Models;
using Test.API.Domain.Services;

namespace Test.API.Controllers
{
    [Route("/api/[controller]")]
    public class OrderssController : Controller
    {
        private readonly IOrdersService _orderService;
        
        public OrderssController(IOrdersService orderService)
        {
            _orderService = orderService;   
        }

        [HttpGet]
        public async Task<IEnumerable<Orders>> GetAllAsync()
        {
            var order = await _orderService.ListAsync();
            return order;
}
    }
}