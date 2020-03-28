# Caching Web API data using Azure Cache for Redis
Redis cache is open source **In-Memory data store**. 
In-Memory is best way to store and get data faster, but its not ideal for persisting data

## Pre-requisite
1. Create azure resource - [Azure Cache for Redis](https://docs.microsoft.com/en-us/azure/azure-cache-for-redis/cache-dotnet-core-quickstart)

Note: Redis Pricing Tier **C0 Basic** offeres upto 250MB cache and is sufficient for the hands-on.

## Configuration Steps
1. Add Nuget package **StackExchange.Redis**

2. Get Primary connection string (Azure Cache for Redis - Settings - Access Keys)

3. Add Primary Connection String to [AppSettings](https://github.com/nidhisht/AzureSamples/blob/10500dc79297729a77002f02211c05e15fa804b7/csharp_dotnetcore/08.webapi-redis/appsettings.Development.json#L11).

4. In Startup.cs, Create a new [ConnectionMultiplexer instance](https://github.com/nidhisht/AzureSamples/blob/67ca70e2188cf7d929f415a406ad863cf6ed1bcb/csharp_dotnetcore/08.webapi-redis/Startup.cs#L24)

5. In Startup.cs, Add a [scoped service of type IDatabase](https://github.com/nidhisht/AzureSamples/blob/67ca70e2188cf7d929f415a406ad863cf6ed1bcb/csharp_dotnetcore/08.webapi-redis/Startup.cs#L25)

6. [Inject IDatabase](https://github.com/nidhisht/AzureSamples/blob/67ca70e2188cf7d929f415a406ad863cf6ed1bcb/csharp_dotnetcore/08.webapi-redis/Controllers/CacheController.cs#L12) in the controller

7. [Set a key](https://github.com/nidhisht/AzureSamples/blob/67ca70e2188cf7d929f415a406ad863cf6ed1bcb/csharp_dotnetcore/08.webapi-redis/Controllers/CacheController.cs#L30) to hold string value in Redis Cache

8. [Get the value](https://github.com/nidhisht/AzureSamples/blob/67ca70e2188cf7d929f415a406ad863cf6ed1bcb/csharp_dotnetcore/08.webapi-redis/Controllers/CacheController.cs#L21) of the key from Redis Cache

## Reference
[youtube]()
