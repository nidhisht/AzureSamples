# Swagger
Swagger is a framework for documenting REST api. 


## Initial Configurations (Swagger Generator & Swagger UI Endpoints)
1. Add Nuget package Swashbuckle.AspNetCore

2. Add swagger generator to the Startup - ConfigureServices()

   **Note**: Documentation title, description, contact details

3. Enable swagger middleware in the startup - Configure()

   **Note**: Swagger endpont URL, description

4. Provide endpoint of Swagger UI in the startup - Configure()

5. Test the swagger (https://localhost:44358/swagger/)


## Inject human friendly description for api methods
6. To update the documentation, goto the web api controller & add comments against the methods

7. Web api project properties -> Build -> Output -> check "XML documentation File"

8. Include XML comments inside swagger generator of Startup - ConfigureServices()
