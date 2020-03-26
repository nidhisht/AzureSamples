using Microsoft.AspNetCore.Mvc;
using StackExchange.Redis;

namespace _08.webapi_redis.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CacheController : ControllerBase
    {
        private readonly IDatabase database;
        private readonly string key="redisKey";
        public CacheController(IDatabase db)
        {
            database = db;
        }

        [HttpGet]
        public string Get()
        {
            if (database.KeyExists(key))
                return database.StringGet(key);
            else
                return "cache is empty";
        }


        [HttpGet("{value}")]
        public string Set(string value)
        {
            database.StringSet(key, value);
            return "added to cache";
        }
    }
}