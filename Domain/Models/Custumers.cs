namespace Test.API.Domain.Models
{
    public class Custumers
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }


        public int OrderId { get; set; }
        public Orders Order { get; set; }
    }
}