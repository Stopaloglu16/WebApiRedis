using WebApiRedis.Models;

namespace WebApiRedis.Data
{
    public class UserRepository : IUserRepository
    {
        public async Task<List<User>> GetUsersAsync()
        {
            List<User> output = new()
            {
                new() { Id = 1, Name = "William Jackson" },
                new() { Id = 2, Name = "Maria Moody" },
                new() { Id = 3, Name = "Monica Howell" }
            };

            await Task.Delay(3000); // simulating data access time

            return output;
        }
    }
}
