# BroadWorks Connector.NET

BroadWorks Connector.NET is a .NET Standard 2.0 library for connecting to the BroadWorks OCI-P API. It is based on the [BroadWorks Connector](https://github.com/cwmiller/broadworks-connector) library for PHP.

### Installation

Install via [NuGet](https://www.nuget.org/packages/BroadWorksConnector):

    Install-Package BroadWorksConnector
    
Or via the .NET Core CLI:

    dotnet add package BroadWorksConnector

### Usage Example

```csharp
// Initialize by passing the OCI-P API's endpoint URL (if using SOAP) along with your BroadWorks username and password.
var ocip = new OcipClient("https://your-bw-soap-endpoint.com/webservice/services/ProvisioningService", "username", "password");

// .. or if connecting via TCP:
// var ocip = new OcipClient("tcp://your-bw-ocs-hostname.com:2208", "username", "password");

// .. or if connecting via TCP+SSL/TLS:
// var ocip = new OcipClient("tls://your-bw-ocs-hostname.com:2209", "username", "password");

// In this example, a single request is made to get all users in a group whose first name is John.

var req1 = new UserGetListInGroupRequest
{
    ServiceProviderId = "test-service-provider",
    GroupId = "test-group",
    SearchCriteriaUserFirstName = new List<SearchCriteriaUserFirstName> {
        new SearchCriteriaUserFirstName
        {
            IsCaseInsensitive = false,
            Mode = SearchMode.EqualTo,
            Value = "John"
        }
    }
};

try
{
    var response = await ocip.CallAsync(req1);

    foreach (var row in response.UserTable.Row)
    {
        Console.WriteLine(row.Col[0]);
    }
}
catch (ErrorResponseException e)
{
    Console.WriteLine($"Server Error: {e.Message}");
}
catch (ValidationException e)
{
    Console.WriteLine($"Validation Error: {e.Message}");
}

// Multiple requests can be executed in a single call to the API too via the CallAllAsync method.
// Here we'll add another request that retrieves all users from another group whose last name starts with an M.

var req2 = new UserGetListInGroupRequest
{
    ServiceProviderId = "test-service-provider",
    GroupId = "test-group",
    SearchCriteriaUserLastName = new List<SearchCriteriaUserLastName> {
        new SearchCriteriaUserLastName
        {
            IsCaseInsensitive = false,
            Mode = SearchMode.StartsWith,
            Value = "M"
        }
    }
};

try
{
    var responses = await ocip.CallAllAsync(new OCIRequest[] { req1, req2 });

    foreach (var response in responses)
    {
        if (response is UserGetListInGroupResponse r)
        {
            foreach (var row in r.UserTable.Row)
            {
                Console.WriteLine(row.Col[0]);
            }
        }
    }

    // The response for a request can be also be retreived
    var res2 = responses.Get(req2);

    foreach (var row in res2.UserTable.Row)
    {
        Console.WriteLine(row.Col[0]);
    }

}
catch (ErrorResponseException e)
{
    Console.WriteLine($"Server Error: {e.Message}");
}
catch (ValidationException e)
{
    Console.WriteLine($"Validation Error: {e.Message}");
}
```