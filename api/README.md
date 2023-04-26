# Coffee API

## Project settings
 -  C# .Net 7 (important, if you choose .Net 6 you'll probably have build errors)
 - The API is built on ASP.NET Core Web API template **controllers unchecked**, which means this is a minimal API approach
 - There should be no need for additional nuget package installs. However, should problems arise, check the project csproj file and
 make sure these are included within the itemgroup tags:

<PackageReference Include="Newtonsoft.Json" Version="13.0.3" />
<PackageReference Include="Swashbuckle.AspNetCore" Version="6.2.3" />
<PackageReference Include="Swashbuckle.AspNetCore.Annotations" Version="6.5.0" />
<PackageReference Include="Microsoft.AspNetCore.OpenApi" Version="7.0.*-*" />

## Tools used in development
 - Visual Studio
 - Google <3 <3 <3
 - Official .Net Minimal API docs

## Thoughts

### Why minimal API?
Microsoft sums it up well: "Minimal APIs are architected to create HTTP APIs with minimal dependencies. They are ideal for microservices
and apps that want to include only the minimum files, features, and dependencies in ASP.NET Core."

### Further improvements of the project
 - Implement unit tests (ahem, cough cough)
 - Seperate out logic of the anonymous functions in the endpoint mappings (getting a bit crowded for sure)
 - Implement SQL database with full blown CRUD abilities!!
 - Additional responses (like 500 as documentetd in the yaml file)

## Liberties I've taken
 - I have omitted 500 responses (as I probably should have), instead incorporated 404 responses whenever the query for some reason does not return any result.
   (Maybe you requested an id of a drink that doesn't exist?)

## Extra notes
I have chosen to abstract away(?) (or is it abstracted out?) the class that actually gets the data (GetData), and created an interface. This way the client doesn't
get anymore than it needs to know, AND the client will not be communicating directly with the 'database'.

FUN DETAIL: 