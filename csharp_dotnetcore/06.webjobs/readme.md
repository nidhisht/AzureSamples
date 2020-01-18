# Run a background task with Web Job
**NOTE: This is a dotnet framework Console application (NOT dotnetcore)**

## Basics
Web job is a process that runs in the background

It complements the main application. In other words, Web job is a supporting mechanism to an existing applications.

There are 2 types of Web Jobs
  1. **Continous Web Job**
  2. **Triggered Web Job**

**Continous Web Job** will run until stopped

**Triggered Web Job** will run only when triggered. It can be started in 2 ways:
  1. Manual
  2. Scheduled


## Observations
1. Web job can be configured on any existing Azure App Service (Web App or Web Api)

2. Web job supports **exe, cmd, ps etc**. But NOT dll's.

3. Any **dotnet Framework console application** can be configured as web job

4. By default, dotnetcore console project output is **dll**. Hence may not be able to configure directly.

5. Scheduling web job can be done using [CRON expressions](https://docs.microsoft.com/en-in/azure/app-service/webjobs-create#ncrontab-expressions)
   
   
## Scenario
Schedule a web job to auto-install applications on Microsoft Teams for all newly onboarded users in the organization. This job will run on all Fridays at 5PM. Use Microsoft Graph APIs for auto-installations.

## Reference
[Youtube](https://www.youtube.com/watch?v=-A6hsUPSkWU)
