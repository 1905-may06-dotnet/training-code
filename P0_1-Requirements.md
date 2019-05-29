# Project - pizzabox
- This is going to be the individual project. 
## [architecture](https://docs.microsoft.com/en-us/dotnet/standard/modern-web-apps-azure-architecture/common-web-application-architectures)
### [solution] PizzaBox.sln
  - [project] PizzaBox.Client.csproj
    -  _The user interface layer in an ASP.NET Core MVC application is the entry point for the application. This project should reference the Application *Domain* project, and its types should interact with *Data layer* strictly through interfaces defined in Application Domain. No direct instantiation of or static calls to the Data layer types should be allowed in the UI layer_
    - [folder] ViewModels
    - [folder] Controllers
    - [folder] Filters
    - [folder] Views
  - [project] PizzaBox.Data.csproj
    - _EF Core types (DbContext, Migration)_
    - _Data access implementation types (Repositories)_
    - [folder] Entities
  - [project] PizzaBox.Domain.csproj
    - _The Application *Domain* holds the business model, which includes entities, services, and interfaces. These interfaces include abstractions for operations that will be performed using *Data*, such as data access, file system access, network calls, etc. Sometimes services or interfaces defined at this layer will need to work with non-entity types that have no dependencies on UI/PL or Data. These can be defined as mappers or simple Data Transfer Objects (DTOs)_
    - [folder] Models - Entities (business model classes that are persisted)    
  - [project] PizzaBox.Testing.csproj
    - [folder] UnitTests
## requirements
### location
- should be able to view its orders
- should be able to view its sales
- should be able to view its inventory
- should be able to view its users
### order
- should be able to view its pizzas
- should be able to compute its cost
- should be able to limit its cost to no more than $5000
- should be able to limit its pizza count to no more than 100
### pizza
- should be able to have a crust
- should be able to have a size
- should be able to compute its cost
- should be able to have at least 2 default toppings
- should be able to limit its toppings to no more than 5
### user
- should be able to view its order history
- should be able to only order from 1 location/day
- should be able to only order 1 time within a 2 hour period
- should be able to only order if an account exists
## technologies
- .NET Core - C#
- .NET Core - EF
- .NET Core - xUnit/MSTest
- ASP.NET Core - MVC
- MS SQL Server - SQL
## timelines
### part1
- complete the C# + xUnit/MSTest portion (the domain portion)
### part2
- complete the EF + SQL portion (the data portion)
### part3
- complete the MVC portion (the interface portion)
## showcase (as many as you can implement)
- as a user i should be able to register
- as a user i should be able to signin
- as a user i should be able to view a list of locations
- as a user i should be able to select a location
- as a user i should be able to make an order
- as a user i should be able to choose custom or preset pizza(s)
- as a user i should be able to select a crust
- as a user i should be able to select a size
- as a user i should be able to select a set of toppings
- as a user i should be able to preview my order
- as a user i should be able to confirm my order
- as a user i should be able to view my order history
- as a user i should be able to signout
