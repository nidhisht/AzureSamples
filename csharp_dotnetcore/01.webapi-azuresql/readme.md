# Web API with Azure Sql connectivity
Prerequisite is to create azure sql database on Azure portal.

## 1. Create Azure Sql database on Azure Portal
Create new SQL database on portal (Azure Portal – New – Database – SQL Database)

- SQL Elastic pool = **No**
- Compute + storage = **Standard**
- Firewall rules: Allow Azure services and resources to access this server = **True**
- Additional Settings: Use existing data = **Sample**

_Notes:_

- **AdventureWorksLT** _will be created as the sample database._
- _Firewall rules can be set later as well._


## 2. Get connectionstring from Azure Portal
Azure portal - Database - Connection strings - Copy ADO.NET (SQL authentication)

_Notes:_
- _Use connectionstring in [SqlHelper.cs](https://github.com/nidhisht/AzureSamples/blob/master/csharp_dotnetcore/01.webapi-azuresql/Helper/SqlHelper.cs) class_
