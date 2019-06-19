# Week 01 - C#
### BASIC
- Common Language Runtime
(BCL, CIL, CLI, CLR, CTS, JIT, VES)
- Runtime Environment
(Garbage Collection, Managed, Unmanaged)
- Datatypes
(Reference, Value)
- Access Modifiers
(Internal, Private, Protected, Public)
- Extended Modifiers
(Abstract, Const, New, Override, Partial, Readonly, Sealed, Static, Virtual)
- Class
(Constructor, Field, Method, Property, Reference Type)
- Struct
(Constructor, Field, Method, Property, Value Type)
- Interface
(Method, Property)
- Enum
(Collection)
- Semantic Code
(DRY, Comments-Inline, Comments-XML, KISS)

### INTERMEDIATE
- Object Oriented Programming
(Abstraction, Encapsulation, Inheritance, Polymorphism)
- Variance
(As, Boxing, Casting, Contravariant, Covariant, Invariant, Is, Out, Ref, TypeOf)
- Collections
(Array, List, Data Structures, Dictionary, Generics)
- Serialization
(File I/O, Regular Expressions, Serializer-JSON, Serializer-Text, Serializer-XML)
- Exception Handling
(Catch, Custom Exceptions, Finally, Throw, Try)
- Test Driven Development
(Code-Coverage, Unit-Testing, Mock)
- Application Monitoring
(Breakpoints, Debugging, Logging, Tracing)

### ADVANCED
- SOLID
(Single-Responsibility, Open-Closed, Liskov-Substitution, Interface-Segregation, Dependency-Inversion)
- Design Patterns
(Creational-Singleton, Creational-Factory)
- Delegates
(Action, Event, Function, Lambda, LINQ, Predicate)
- Multithreading
(Async-Await, Task, Thread)
- Git
(Add, Commit, Log, Pull, Push, Status)

### _Tools_
- .NET Core [2.x]
- C# [7.x]
- xUnit [2.x] / MSTest [2.x]
- Serilog [2.x] / ILogger [2.x] / NLog
- Visual Studio [2017]/[2019]
- Visual Studio Code [1.x]
- Git [2.x]

#### References
- [Basic Syntax](https://docs.microsoft.com/en-in/dotnet/csharp/language-reference/language-specification/introduction)

# Week 02 SQL
### BASIC
- RDBMS (Normalization, Multiplicity)
- DML (Select, Insert, Update, Delete)
- DDL (Create, Alter, Drop, Truncate)
- JOIN (Inner-Join, Left-Join, Right-Join, Full-Join, Cross-Join, Self-Join)
- UNION (Union, Union-All, Intersect, Except)
- Subquery (CTE, Using-From, Using-Where)
- Aggregate (Average, Count, Sum)

### INTERMEDIATE
- View (Schema, Query)
- Function (Parameter, Scalar, Tabular)
- Stored Procedure 
- Trigger (For, After, Instead-Of, Insert, Update, Delete)
- Transaction (Commit, Rollback, Savepoint)

### ADVANCED
- ACID(Atomicity, Consistency, Isolation, Durability)
- Design Patterns(Structural-Facade, Structural-Repository)
- ADO.NET(Connected-Architecture, Disconnected-Architecture)
- ORM(Database-First Approach)

### _Tools_
- Transact-SQL [2017]
- Entity Framework Core [2.x]
- SQL Server [2017]
- Azure SQL Databases
- SQL Server Mgmt Studio [2017]

# Week 03 MVC
### BASIC
- HTML Fundamentals
- HTML5 new features
- Multimedia (Audio, Canvas, Video)
- Forms (Input, Validation)
- CSS Fundamentals (Box-Model, Media-Queries, Positioning, Responsive-Design, Rulesets, Values-Color, Values-Size)
- Selectors (Class, Id, Omni, Parent-Child, Ancestor-Descendant, Pseudo-Classes, Pseudo-Elements, Sibling, Tag)

### INTERMEDIATE
- MVC Concepts(Controller, Model, View)
- Request Lifecycle (DNS, Response, Request)
- Controller (Actions, HTTP Verbs)
- Model (Data-Annotations, ViewModel)
- View (Partial-Views, Strongly-Typed, Weakly-Typed)
- Routing (Global, Controller, Action)

### ADVANCED
- Filters (Action, Authorization, Custom, Exception, Response)
- Helpers (Custom, HTML, Tag)
- Model Binding
- ORM (Code-First Approach)

### _Tools_
- ASP.NET MVC Core [2.x]
- Entity Framework Core [2.x]

# Week 04 DevOps
### BASIC
- [Software Development Lifecycle](https://www.tutorialspoint.com/sdlc/)
(Waterfall, V-Model, Agile)
- Source Control Management 
(Branch, DVCS-[Git](https://www.atlassian.com/git/tutorials/what-is-version-control), Merge, Pull-Request)
- [DevOps](https://docs.microsoft.com/en-us/azure/devops/learn/what-is-devops)
(CI/CD, [Azure DevOps Pipeline](https://docs.microsoft.com/en-us/azure/devops/pipelines/languages/dotnet-core?view=azure-devops), Build-Definition, Code-Analysis, Release-Definition)

### INTERMEDIATE
- Cloud Computing
(Hybrid, Private, Public, IaaS, PaaS, SaaS, CaaS)
- Docker Fundamentals
(Definition, Image, Container, Registry, Machine, Orchestration)
- Configuration and Compose Files

### ADVANCED
- Analysis
(Code-Coverage, Code-Review, Technical-Debt)
- Testing
(Unit-Testing, Test-Runner)
### _Tools_
- Azure
- Azure DevOps
- SonarCloud
- Docker [18.x]
- Git [2.x]

# Week 05 Web Services
  - [Service Oriented Architecture](https://www.guru99.com/soa-principles.html)
    (Patterns, Principles, Endpoint, Address, Binding, Contract)
  - [SOAP](https://www.tutorialspoint.com/soap/what_is_soap.htm)
    (Envelope, Header, Body)
  - [WCF](https://docs.microsoft.com/en-us/dotnet/framework/wcf/fundamental-concepts)
  - [WSDL](https://www.tutorialspoint.com/wsdl/wsdl_introduction.htm)
    (Port, Binding, PortType, Operation)
  - [REST Fundamentals](https://restfulapi.net/rest-architectural-constraints/)
    (Uniform-Interface, Client-Server, Stateless, Cacheable, Layered, Code-On-Demand)
  - [HTTP](https://developer.mozilla.org/en-US/docs/Web/HTTP)
    (Method, Safe, Idempotent, Status-Code, Header-Request, Header-Response)
  - [REST Server](https://docs.microsoft.com/en-us/aspnet/core/web-api/?view=aspnetcore-2.2)
    (CORS, XSS, CSRF)
  - Media Type
    (JSON,[Content-Negotiation](https://docs.microsoft.com/en-us/aspnet/core/web-api/advanced/formatting?view=aspnetcore-2.2), [Action-Result Types](https://docs.microsoft.com/en-us/aspnet/core/web-api/action-return-types?view=aspnetcore-2.2), [Formatter](https://docs.microsoft.com/en-us/aspnet/core/web-api/advanced/custom-formatters?view=aspnetcore-2.2))
  - REST Client
    (Consumer, [Http-Client](https://docs.microsoft.com/en-us/dotnet/csharp/tutorials/console-webapiclient))
  - Security
    (Authentication, Authorization)
  - JavaScript
    (ES5, ES6, Truthy-Falsy, Equality-Loose, Datatypes, DOM, JSON, Prototypes, Scopes)
  - Functions
    (Arrow, Callback, Closure, IIFE)
  - Ajax Fundamentals
    (Fetch API, HTTP Verbs, XmlHttpRequest)
  - Event Handlers
    (Listeners, Propagation)

# Week 06 Angular
- [TypeScript Fundamentals](https://www.typescriptlang.org/docs/handbook/basic-types.html)
- [Angular](https://angular.io/docs)

_Tools_
- TypeScript [3.x]
- Angular [6.x]
- Jasmine [3.x]
- Karma [2.x]
- Webpack [4.x]


# _Week 07 Microservices_** 
