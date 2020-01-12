# Enable Azure Application Insights Telemetry in .NET Core Web App

This sample configures **web request logging of .NET core Web App** in Azure Application Insights.

## Steps (Azure Portal)
Create new Azure resources (Application Insights)

Copy the **Instrumentation Key** from portal 

## Steps (.NET core Web App)
Add nuget package **Microsoft.ApplicationInsights.AspNetCore**

Add **Instrumentation Key** in ApplicationSettings.Json

Add **Application Insights Telemetry** in the Starup.cs
