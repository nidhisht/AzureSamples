# Web Api Connecting to Azure Cosmos DB

Cosmos DB is a **multi-model**, **globally distributed** database.

This sample covers **Core SQL API** in Cosmos DB.

## Pre-requisite
1. Create azure resource - [Azure Cosmos DB](https://docs.microsoft.com/en-us/azure/cosmos-db/create-sql-api-dotnet)


## Configuration Steps

1. Add Nuget package **Microsoft.Azure.Cosmos**

2. Get Primary Connection String (Azure portal - Azure Cosmos Db - Settings - Keys)

3. Add [Primary Connection String](https://github.com/nidhisht/AzureSamples/blob/45438ad735b463bd0dc22576042702c445a97ac5/csharp_dotnetcore/09.webapi-cosmos-sqlapi/appsettings.Development.json#L10) to Appsettings.json

4. Add [Database id](https://github.com/nidhisht/AzureSamples/blob/45438ad735b463bd0dc22576042702c445a97ac5/csharp_dotnetcore/09.webapi-cosmos-sqlapi/appsettings.Development.json#L11), [Container id](https://github.com/nidhisht/AzureSamples/blob/45438ad735b463bd0dc22576042702c445a97ac5/csharp_dotnetcore/09.webapi-cosmos-sqlapi/appsettings.Development.json#L12) & [Partition key](https://github.com/nidhisht/AzureSamples/blob/45438ad735b463bd0dc22576042702c445a97ac5/csharp_dotnetcore/09.webapi-cosmos-sqlapi/appsettings.Development.json#L13) to AppSettings.json  (Refer below screenshot for details)

5. Instantiate [Container](https://github.com/nidhisht/AzureSamples/blob/45438ad735b463bd0dc22576042702c445a97ac5/csharp_dotnetcore/09.webapi-cosmos-sqlapi/DataAccess/CosmosDbHelper.cs#L18) in the CosmosDbHelper


## Basics
Cosmos DB enables horizontal scaling.

Cosmos DB stores documents in collections. Within collections, documents are split into groups called Logical Partitions. It is through Partition keys. Cosmos DB reshuffles logical partitions into physical servers using physical partitions.

![](https://user-images.githubusercontent.com/42999787/79558583-012da200-80c2-11ea-8637-660c1a6b09f3.png)

## Reference
[Cosmos - Quick start](https://docs.microsoft.com/en-us/azure/cosmos-db/create-sql-api-dotnet)

[Best practices for Azure Cosmos DB: Data modeling, Partitioning and RUs (VIDEO)](https://azure.microsoft.com/en-in/resources/videos/build-2019-best-practices-for-azure-cosmos-db-data-modeling-partitioning-and-rus/)
