# Coffee API

## Project settings
 -  C# .Net 7 (important, if you choose .Net 6 you'll probably have build errors)
 - The API is built on ASP.NET Core Web API template **controllers unchecked**, which means this is a minimal API approach
 - The project implements some very basic unit tests with xunit (.Net 7) test project. To run the tests, simply head over to View -> Test Explorer and run the tests from there.
 

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

## Extra notes
I have chosen to abstract away(?) (or is it abstracted out?) the class that actually gets the data (GetData), and created an interface. This way the client doesn't
get anymore than it needs to know, AND the client will not be communicating directly with the 'database'.

### Git chaos
I'm terribly sorry for the git chaos. Rearranging the folder structure probably messed up gitignore and it's possible that some folders that shouldn't be in git ended up there.
Please, hit me up if you have any questions during assessment:

E:M:A:I:L:::: p u n k t h o r  {at} g m a i l . c o m
p:H:o:N:e:::: + 4 7  9 1 5 3 5 8 0 9
 