using _09.webapi_cosmos_sqlapi.Configuration;
using _09.webapi_cosmos_sqlapi.Entity;
using Microsoft.Azure.Cosmos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace _09.webapi_cosmos_sqlapi.DataAccess
{
    public class CosmosDbHelper
    {
        private readonly Container container;
        private readonly string partitionKey;
        public CosmosDbHelper(CosmosSettings settings)
        {
            CosmosClient cosmosClient = new CosmosClient(settings.PrimaryConnectionString);
            Database database = cosmosClient.GetDatabase(settings.DatabaseId);
            container = database.GetContainer(settings.ContainerId);
            partitionKey = settings.PartitionKey;
        }

        public async Task Create(Order order)
        {
            await container.CreateItemAsync<Order>(order, new PartitionKey(order.Id));
        }

        public async Task Update(Order order)
        {
            await container.UpsertItemAsync<Order>(order);
        }

        public async Task Delete(string id)
        {
            await container.DeleteItemAsync<Order>(id.ToString(), new PartitionKey(id));
        }

        public async Task<List<Order>> GetOrders()
        {
            QueryDefinition queryDefinition = new QueryDefinition("select * from c");
            FeedIterator<Order> response = container.GetItemQueryIterator<Order>(queryDefinition);

            List<Order> orders = new List<Order>();
            FeedResponse<Order> orderFeedResponse;
            while(response.HasMoreResults)
            {
                orderFeedResponse = await response.ReadNextAsync();
                foreach(Order order in orderFeedResponse)
                {
                    orders.Add(order);
                }
            }   
            return orders;
        }

        public async Task<Order> GetOrder(Guid id)
        {
            QueryDefinition queryDefinition = new QueryDefinition( string.Format("select * from c where c.id='{0}'",id.ToString()));
            FeedIterator<Order> response = container.GetItemQueryIterator<Order>(queryDefinition);

            Order order = new Order();
            FeedResponse<Order> orderFeedResponse;
            while (response.HasMoreResults)
            {
                orderFeedResponse = await response.ReadNextAsync();
                foreach (Order odr in orderFeedResponse)
                {
                    order = odr; 
                }
            }
            return order;
        }


    }
}
