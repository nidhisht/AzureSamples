namespace _09.webapi_cosmos_sqlapi.Configuration
{
    public class CosmosSettings
    {
        public string PrimaryConnectionString { get; set; }
        public string DatabaseId{ get; set; }
        public string ContainerId { get; set; }
        public string PartitionKey { get; set; }

    }
}
