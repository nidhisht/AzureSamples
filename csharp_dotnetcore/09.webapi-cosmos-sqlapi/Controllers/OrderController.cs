using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using _09.webapi_cosmos_sqlapi.Configuration;
using _09.webapi_cosmos_sqlapi.DataAccess;
using _09.webapi_cosmos_sqlapi.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace _09.webapi_cosmos_sqlapi.Controllers
{
    /// <summary>
    /// Everything about Orders
    /// </summary>
    [Route("[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly CosmosDbHelper cosmosDbHelper;
        public OrderController(IOptions<CosmosSettings> settings)
        {
            CosmosSettings cosmosSettings = settings.Value;
            cosmosDbHelper = new CosmosDbHelper(cosmosSettings);
        }

        /// <summary>
        /// Find all Orders
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<List<Order>> Get()
        {
            return await cosmosDbHelper.GetOrders();
        }

        /// <summary>
        /// Find Order by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}", Name = "Get")]
        public async Task<Order> Get(Guid id)
        {
            return await cosmosDbHelper.GetOrder(id);
        }

        /// <summary>
        /// Add a new Order
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Order order)
        {
            await cosmosDbHelper.Create(order);
            ApiResponse result = new ApiResponse
            {
                HttpCode = HttpStatusCode.Created,
                Message = "Order created successfully",
                Data = order
            };
            return Created("", result);
        }

        
        /// <summary>
        /// Update an existing Order
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        [HttpPut]
        public async Task<ApiResponse> Put([FromBody] Order order)
        {
            await cosmosDbHelper.Update(order);
            ApiResponse result = new ApiResponse
            {
                HttpCode = HttpStatusCode.OK,
                Message = "Order updated successfully",
                Data = order
            };
            return result;
        }

        /// <summary>
        /// Delete an Order
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public async Task<ApiResponse> Delete(string id)
        {
            await cosmosDbHelper.Delete(id);
            ApiResponse result = new ApiResponse
            {
                HttpCode = HttpStatusCode.OK,
                Message = "Order deleted successfully",
                Data = id
            };
            return result;
        }

        /// <summary>
        /// Populate mock Order
        /// </summary>
        /// <returns></returns>
        [HttpGet("Populate")]
        public async Task<Order> PopulateMockOrder()
        {
            Order order = MockOrder.Populate();
            await cosmosDbHelper.Create(order);
            return order;
        }


    }
}
