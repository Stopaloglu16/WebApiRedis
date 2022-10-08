using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;
using WebApiRedis.Data;
using WebApiRedis.Helpers;

namespace WebApiRedis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RedisStringController : ControllerBase
    {

        private readonly ILogger<RedisStringController> _logger;
        private readonly IUserRepository _userRepository;
        private IDistributedCache _cache;
        private string _RedisKeyname;

        public RedisStringController(ILogger<RedisStringController> logger, IUserRepository userRepository, IDistributedCache cache)
        {
            _logger = logger;
            _userRepository = userRepository;
            _cache = cache;
            _RedisKeyname = "GoldKey";
        }


        [HttpGet]
        public async Task<IActionResult> GetString()
        {
            var myRtnVal = await _cache.GetStringAsyncHelper(_RedisKeyname);

            if (myRtnVal is null) // Data not available in the Cache
            {
                return BadRequest();
            }

            return Ok(myRtnVal);
        }


        [HttpPut]
        public async Task<IActionResult> SetString(string myKeyValue)
        {
            await _cache.SetStringAsyncHelper(_RedisKeyname, myKeyValue);

            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveString()
        {
            await _cache.RemoveStringAsyncHelper(_RedisKeyname);

            return Ok();
        }


    }
}
