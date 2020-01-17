# Reading Appsettings.json in Web Api
It’s advisable to create different AppSettings.json files for different environment. These configurations will be picked up by the runtime automatically.

| Settings | Description |
| --- | --- |
| AppSettings.json | Generic or common configuration |
| AppSettings.Development.json | Configuration related to Development environment |
| AppSettings.Staging.json | Configuration related to Staging environment |
| AppSettings.Production.json | Configuration related to Production environment |

**Note**: If same configuration is present in [**AppSettings.json**](https://github.com/nidhisht/AzureSamples/blob/c0a0e8d8098a728d39ba1f85be324b17d9099833/csharp_dotnetcore/05.read-appsettings-webapi/appsettings.json#L8) & [**AppSettings.Production.json**](https://github.com/nidhisht/AzureSamples/blob/d22bb5090a362aacec08c3af3f98fa15046c9f5b/csharp_dotnetcore/05.read-appsettings-webapi/appsettings.Production.json#L14), then preference will be given to the [**AppSettings.Production.json**](https://github.com/nidhisht/AzureSamples/blob/d22bb5090a362aacec08c3af3f98fa15046c9f5b/csharp_dotnetcore/05.read-appsettings-webapi/appsettings.Production.json#L14)

## Different ways of reading AppSettings

1. Key/Value application configuration properties

    [var owner = Configuration["ApplicationSettings:Owner"];](https://github.com/nidhisht/AzureSamples/blob/b601563f1c9db0c8e1697b6012451b13298f57d5/csharp_dotnetcore/05.read-appsettings-webapi/Startup.cs#L17)

    [var title = Configuration["Title"];](https://github.com/nidhisht/AzureSamples/blob/5780b9ea7903817e1fabb26e2c079db80c115478/csharp_dotnetcore/05.read-appsettings-webapi/Startup.cs#L18)


2.	Register a configuration Instance in Startup.cs.

    [services.Configure<DatabaseSettings>(Configuration.GetSection("DatabaseSettings"));](https://github.com/nidhisht/AzureSamples/blob/5780b9ea7903817e1fabb26e2c079db80c115478/csharp_dotnetcore/05.read-appsettings-webapi/Startup.cs#L27)


    **Note**: Change in [Controller](https://github.com/nidhisht/AzureSamples/blob/5842f10d6ed482fb6dfc4cec5b544cb1bf43468b/csharp_dotnetcore/05.read-appsettings-webapi/Controllers/ValuesController.cs#L14) is needed - using [Options pattern](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/configuration/options?view=aspnetcore-3.1)

## Testing AppSettings.Environment locally

VS 2017 – Debug menu – Project Properties – Environment Variable – ASPNETCORE_ENVIRONMENT = Production

Or other option is to make change in [**LaunchSettings.json**](https://github.com/nidhisht/AzureSamples/blob/d22bb5090a362aacec08c3af3f98fa15046c9f5b/csharp_dotnetcore/05.read-appsettings-webapi/Properties/launchSettings.json#L17)

## Reference
[youtube](https://www.youtube.com/watch?v=nIoDpTPIle8)
