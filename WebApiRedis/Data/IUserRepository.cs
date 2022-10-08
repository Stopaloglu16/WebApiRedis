using WebApiRedis.Models;

namespace WebApiRedis.Data
{
    public interface IUserRepository
    {
        Task<List<User>> GetUsersAsync();
    }
}
