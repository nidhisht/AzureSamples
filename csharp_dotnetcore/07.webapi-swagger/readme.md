# Swagger
Swagger is a framework for documenting REST api. 


## Initial Configurations (Swagger Generator & Swagger UI Endpoints)
1. Add Nuget package Swashbuckle.AspNetCore

2. Add [Swagger Generator](https://github.com/nidhisht/AzureSamples/blob/9a32b4021ed9ff2a1eead5eaf89648231833530d/csharp_dotnetcore/07.webapi-swagger/Startup.cs#L29) to the Startup - ConfigureServices()

   **Note**: Documentation title, description, contact details

3. Enable [Swagger Middleware](https://github.com/nidhisht/AzureSamples/blob/9a32b4021ed9ff2a1eead5eaf89648231833530d/csharp_dotnetcore/07.webapi-swagger/Startup.cs#L64) in the startup - Configure()

   **Note**: Swagger endpont URL, description

4. Provide endpoint of [Swagger UI](https://github.com/nidhisht/AzureSamples/blob/9a32b4021ed9ff2a1eead5eaf89648231833530d/csharp_dotnetcore/07.webapi-swagger/Startup.cs#L65) in the startup - Configure()

5. Test the swagger (https://localhost:44358/swagger/)


## Inject human friendly description for api methods
6. To update the documentation, goto the web api controller & [add comments](https://github.com/nidhisht/AzureSamples/blob/9a32b4021ed9ff2a1eead5eaf89648231833530d/csharp_dotnetcore/07.webapi-swagger/Controllers/ValuesController.cs#L11) against the methods

7. Web api project properties -> Build -> Output -> check "XML documentation File"

8. [Include XML comments](https://github.com/nidhisht/AzureSamples/blob/9a32b4021ed9ff2a1eead5eaf89648231833530d/csharp_dotnetcore/07.webapi-swagger/Startup.cs#L43) inside swagger generator of Startup - ConfigureServices()

## Reference
[Youtube](https://www.youtube.com/watch?v=qlEZE1K5BI4)
