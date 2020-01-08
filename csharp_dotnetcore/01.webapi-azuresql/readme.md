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
- _Use connectionstring in [Helper/SqlHelper.cs](https://github.com/nidhisht/AzureSamples/blob/master/csharp_dotnetcore/01.webapi-azuresql/Helper/SqlHelper.cs) class_

## 3. Test the web Api (locally)
http://localhost:51192/api/values

http://localhost:51192/api/values/5

http://localhost:51192/api/Customers

http://localhost:51192/api/Customers/5

_Notes:_
- _Above port can differ_

## 4. Test the web Api (after publishing to Azure Portal)
https://adventureworks162api.azurewebsites.net/api/customers

https://adventureworks162api.azurewebsites.net/api/customers/5

