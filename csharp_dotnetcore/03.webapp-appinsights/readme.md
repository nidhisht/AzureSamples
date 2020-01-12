# Enable Azure Application Insights Telemetry in .NET Core Web App

This sample configures **web request logging of .NET core Web App** in Azure Application Insights.

## Steps (Azure Portal)
Create new Azure resources (Application Insights)

Copy the **Instrumentation Key** from portal 

## Steps (.NET core Web App)
Add nuget package **Microsoft.ApplicationInsights.AspNetCore**

Add **Instrumentation Key** in [ApplicationSettings.Json](https://github.com/nidhisht/AzureSamples/blob/328df6fbd0482f1a086d3ab857c3c728057c0ead/csharp_dotnetcore/03.webapp-appinsights/appsettings.json#L2)

Add **Application Insights Telemetry** in the [Starup.cs](https://github.com/nidhisht/AzureSamples/blob/4865ebf90752f4bde568819bd5ac6d26a3a3125a/csharp_dotnetcore/03.webapp-appinsights/Startup.cs#L33)
