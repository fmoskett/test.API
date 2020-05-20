using System;
using System.Collections.Generic;

namespace Test.API.Domain.Models
{
    public class Orders
    {
        public int Id { get; set; }
        public string productName { get; set; }
        public DateTime dtOrder { get; set; }
        public short Amount { get; set; }
        public decimal Price { get; set; }
        public Orders Order { get; set; }
        public IList<Custumers> Custumer { get; set; } = new List<Custumers>();
    }
}