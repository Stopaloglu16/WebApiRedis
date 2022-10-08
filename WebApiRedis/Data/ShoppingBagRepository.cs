using WebApiRedis.Models;

namespace WebApiRedis.Data
{
    public class ShoppingBagRepository : IShoppingBagRepository
    {

        public async Task<List<ShoppingBag>> GetShoppingBagAsync()
        {
            List<ShoppingBag> output = new List<ShoppingBag>()
            {
                new() {  Id = 1, Price = 3, Quantity= 3, Note = "" }
              
            };

            await Task.Delay(3000); // simulating data access time

            return output;
        }
    }
}
