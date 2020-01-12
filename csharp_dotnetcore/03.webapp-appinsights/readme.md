# Enable Azure Application Insights Telemetry in .NET Core Web App

This sample configures **web request logging of .NET core Web App** in Azure Application Insights.

_Note: InstrumentationKey uniqely identifies Application Insights in Azure Portal_

## Steps (Azure Portal)
Create new Azure resources (Application Insights)

Copy the **Instrumentation Key** from portal 

## Steps (.NET core Web App)
Add nuget package **Microsoft.ApplicationInsights.AspNetCore**

Add **Instrumentation Key** in [ApplicationSettings.Json](https://github.com/nidhisht/AzureSamples/blob/328df6fbd0482f1a086d3ab857c3c728057c0ead/csharp_dotnetcore/03.webapp-appinsights/appsettings.json#L2)

Add **Application Insights Telemetry** in the [Starup.cs](https://github.com/nidhisht/AzureSamples/blob/4865ebf90752f4bde568819bd5ac6d26a3a3125a/csharp_dotnetcore/03.webapp-appinsights/Startup.cs#L33)

## Observations
1. Local web app (not published) with **Instrumentation Key** can send messages to Azure Application Insights.

2. There is few minutes delay in seeing logs in Azure Application Insights. 

3. There's a query language available in Application Insights - **Kusto query language (KQL)**.

4. Data retention can be upto 730 days (2 years). Upto 90 days is free, post that is chargable.
