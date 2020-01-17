# Reading Appsettings.json in Web Api
It’s advisable to create different AppSettings.json files for different environment. These configurations will be picked up by the runtime automatically.

**Note**: If same configuration is present in **AppSettings.json** & **AppSettings.<environment>.json**, then preference will be given to the **AppSettings.<environment>.json**

## Different ways of reading AppSettings

1. Key/Value application configuration properties

var owner = Configuration["ApplicationSettings:Owner"];

var title = Configuration["Title"];


2.	Register a configuration Instance in Startup.cs – ConfigureServices().

services.Configure<DatabaseSettings>(Configuration.GetSection("DatabaseSettings"));


## Testing AppSettings.Environment locally

VS 2017 – Debug menu – Project Properties – Environment Variable – ASPNETCORE_ENVIRONMENT = Production
