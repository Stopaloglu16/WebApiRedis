using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;
using WebApiRedis.Data;
using WebApiRedis.Helpers;
using WebApiRedis.Models;

namespace WebApiRedis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RedisModelController : ControllerBase
    {
        private readonly ILogger<RedisModelController> _logger;
        private readonly IUserRepository _userRepository;
        private IDistributedCache _cache;

        public RedisModelController(ILogger<RedisModelController> logger, IUserRepository userRepository, IDistributedCache cache)
        {
            _logger = logger;
            _userRepository = userRepository;
            _cache = cache;
        }


        [HttpGet]
        public async Task<ActionResult<List<ShoppingBag>>> GetModel()
        {

            var myusers = await _userRepository.GetUsersAsync();

            var myRtnVal = await _cache.GetRecordAsync<List<ShoppingBag>>(myusers[0].Id.ToString());

            if(myRtnVal == null)
            {
                _logger.LogWarning("Not found");
            }

            return Ok(myRtnVal);
        }


        [HttpPut]
        public async Task<IActionResult> SetModel(List<ShoppingBag> mybagList)
        {
            var myusers = await _userRepository.GetUsersAsync();

            await _cache.SetRecordAsync(myusers[0].Id.ToString(), mybagList);

            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveString()
        {
            var myusers = await _userRepository.GetUsersAsync();

            await _cache.RemoveStringAsyncHelper(myusers[0].Id.ToString());

            return Ok();
        }

    }
}
