# Caching Web API data using Azure Cache for Redis
Redis cache is open source **In-Memory data store**. 
In-Memory is best way to store and get data faster, but its not ideal for persisting data

## Pre-requisite
1. Create azure resource - [Azure Cache for Redis](https://docs.microsoft.com/en-us/azure/azure-cache-for-redis/cache-dotnet-core-quickstart)

Note: Redis Pricing Tier **C0 Basic** offeres upto 250MB cache and is sufficient for the demo.

## Configuration Steps
1. Add Nuget package **StackExchange.Redis**

2. Get Primary connection string (Azure Cache for Redis - Settings - Access Keys) and add to [AppSettings](https://github.com/nidhisht/AzureSamples/blob/10500dc79297729a77002f02211c05e15fa804b7/csharp_dotnetcore/08.webapi-redis/appsettings.Development.json#L11).

3. 
