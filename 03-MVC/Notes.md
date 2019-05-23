## Asp.Net MVC Core 2.2
- ASP.NET Core is a cross-platform, high-performance, open-source framework for building modern, cloud-based, Internet-connected applications. With ASP.NET Core, you can:
    - Build web apps and services, IoT apps, and mobile backends.
    - Use your favorite development tools on Windows, macOS, and Linux.
    - Deploy to the cloud or on-premises.
    - Run on .NET Core or .NET Framework.
- ASP.NET Core is a redesign of ASP.NET 4.x, with architectural changes that result in a leaner, more modular framework

### Set Up 
- Windows - VS2019 with .net core workload
- Any platform -(Mac OS/Linux/Windows)
    - Editor : VSCode, Sublime, Visual Studio
    - Environment : .net Core SDK 2.x

### Create Asp.Net MVC app using Visual Studio 2019
- File->New Project->Program Type-Web-> Asp.Net Core -> Empty project

### Create Asp.Net MVC app using .Net CLI Commands and Visual Studio Code 
- Open the integrated terminal.
- Change to the directory (cd) which will contain the project.
- Run the following commands:
    - ```dotnet new webapp -n/-o _Folder name_/_ProjectName_```
    - ```code -r _ProjectName_```
- Trust the HTTPS development certificate by running the following command:
    - ```dotnet dev-certs https --trust```
- To run the application either :
    - Ctrl + F5
    - or type command ```dotnet run``` on Terminal
### Servers:
    - InProcess : 
        - uses IIS Express Server ???
        - ```<AspNetCoreHostingModel>InProcess</AspNetCoreHostingModel>```
        - Better in performance then Out process 
    - OutProcess : By default .Net CLI uses Kestrel server for hosting the app irrespective of ```<AspNetCoreHostingModel>InProcess/OutProcess</AspNetCoreHostingModel>```
        - Internal : Kestrel (cross-platform process)
        - External : IIS/NginX/Apache as reverse proxy server and Kestrel used in combination with.


_References_
- [Asp.Net Core Fundamentals](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/index?view=aspnetcore-2.2&tabs=windows)
-  [Asp.Net Core MVC App](https://docs.microsoft.com/en-us/aspnet/core/tutorials/razor-pages/razor-pages-start?view=aspnetcore-2.2)
- [Data Access using EF Core with ASP.Net core MVC](https://docs.microsoft.com/en-us/aspnet/core/data/ef-rp/intro?view=aspnetcore-2.2)

