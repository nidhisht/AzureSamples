# Azure Web App consuming web api
This sample uses **HttpClient** for invoking the Web Api and **Newtonsoft.Json** for deserializing Web Api response.


# Pre-requisites – Setup the web project:

1. Add new Controller = CustomerController.cs

2. Add new Model = Customer.cs

3. CustomerController.cs – **Add View** by right clicking on Index method

	View Name = Index

	Template = List

	Model Class=Customer

	Use a Layout page = ~/Views/Shared/\_Layout.cshtml

4. \_Layout.html – [add li element for customer[(https://github.com/nidhisht/AzureSamples/blob/8026a6b260d6b793413cbcbbc1c63583a0580a5c/csharp_dotnetcore/02.webapp-consume-webapi/Views/Shared/_Layout.cshtml#L38)

	_Note: **asp-controller** =&quot;Customer&quot; **asp-action** =&quot;Index&quot;_

5. Run the project (Customer page should appear while clicking on Customer menu)

# Consume Web Api:

1. Add Nuget package - Newtonsoft.Json

2. Use [HttpClient (System.Net.Http.HttpClient) for invoking the web Api](https://github.com/nidhisht/AzureSamples/blob/8026a6b260d6b793413cbcbbc1c63583a0580a5c/csharp_dotnetcore/02.webapp-consume-webapi/Controllers/CustomerController.cs#L17)

3. Use [Newtonsoft.Json for deserializing the Web Api response](https://github.com/nidhisht/AzureSamples/blob/8026a6b260d6b793413cbcbbc1c63583a0580a5c/csharp_dotnetcore/02.webapp-consume-webapi/Controllers/CustomerController.cs#L30)

	_Note: Class name can be different while deserializing the object. Ensure that the properties are same as of Web Api Entity._
