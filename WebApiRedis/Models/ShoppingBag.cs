namespace WebApiRedis.Models
{
    public class ShoppingBag
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public string? Note { get; set; }
    }
}
