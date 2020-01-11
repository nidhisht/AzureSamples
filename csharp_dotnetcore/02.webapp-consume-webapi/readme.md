# Azure Web App consuming web api
This sample uses *HttpClient* for invoking the Web Api and *Newtonsoft.Json* for deserializing Web Api response.


# Pre-requisites – Setup the web project:

1. Add new Controller = CustomerController.cs

2. Add new Model = Customer.cs

3. CustomerController.cs – **Add View** by right clicking on Index method

	View Name = Index

	Template = List

	Model Class=Customer

	Use a Layout page = ~/Views/Shared/\_Layout.cshtml

4. \_Layout.html – add li element for customer

	_Note: **asp-controller** =&quot;Customer&quot; **asp-action** =&quot;Index&quot;_

5. Run the project (Customer page should appear while clicking on Customer menu)

# Consume Web Api:

1. Add Nuget package - Newtonsoft.Json

2. Use HttpClient (System.Net.Http.HttpClient) for invoking the web Api

3. Use Newtonsoft.Json for deserializing the Web Api response
	_Note: Class name can be different while deserializing the object. Ensure that the properties are same as of Web Api Entity._
