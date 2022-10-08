using WebApiRedis.Models;

namespace WebApiRedis.Data
{
    public interface IShoppingBagRepository
    {
        Task<List<ShoppingBag>> GetShoppingBagAsync();
    }
}
