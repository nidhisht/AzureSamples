using _01.webapi_azuresql.Entities;
using _01.webapi_azuresql.Helper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace _01.webapi_azuresql.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        // GET api/Customers
        [HttpGet]
        public ActionResult<IEnumerable<Customer>> Get()
        {
            SqlHelper sqlHelper = new SqlHelper();
            return sqlHelper.GetCustomers();
        }

        // GET api/Customers/5
        [HttpGet("{id}")]
        public ActionResult<Customer> Get(int id)
        {
            SqlHelper sqlHelper = new SqlHelper();
            return sqlHelper.GetCustomer(id);
        }
    }
}
