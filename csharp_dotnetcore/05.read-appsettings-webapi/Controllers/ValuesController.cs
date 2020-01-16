using System.Collections.Generic;
using _05.read_appsettings_webapi.Configuration;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace _05.read_appsettings_webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        ApplicationSettings applicationSettings;
        DatabaseSettings databaseSettings;
        public ValuesController(IOptions<ApplicationSettings> appSettings, IOptions<DatabaseSettings> dbSettings)
        {
            applicationSettings = appSettings.Value;
            databaseSettings = dbSettings.Value;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            var environment = applicationSettings.Environment;
            var owner = applicationSettings.Owner;
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
