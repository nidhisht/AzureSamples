# Web API with Azure Sql connectivity
Prerequisite is to create azure sql database on Azure portal. Ensure that sample adventureworks database is created database.

## 1. Create Azure Sql database on Azure Portal

### 1.1. Create sample adventureworks database

## 2. Get connectionstring from Azure Portal

## 3. Firewall setting on Azure portal

### 3.1. Allow Azure services and resources to access database server



1. Create new SQL database on portal (Azure Portal – New – Database – SQL Database)

- SQL Elastic pool = **No**
- Compute + storage = **Standard**
- Firewall rules: Allow Azure services and resources to access this server = **True**
- Additional Settings: Use existing data = **Sample**
  - _Note:_ **AdventureWorksLT** _will be created as the sample database._

2. After successful creation, copy connectionstring
3. Configure firewall setting (Azure portal – Database server)
