# Entity Framework Core Steps:

## Package Manager Console (for VS2019 users)
- Run following commands in your Data Layer project in the VS2019 PMC (in your Tools menu option->Nuget Package Manager -> Package Manager Console)
- `Install-Package Microsoft.EntityFrameworkCore.SqlServer`
- `Install-Package Microsoft.EntityFrameworkCore.Tools`
- `Install-Package Microsoft.EntityFrameworkCore.Design`
- Build the project before Scaffolding
- `Get-Help about_EntityFrameworkCore` - See the EF help commands
- `Scaffold-DbContext -connection "Server=<DB Server Name>;Database=<DB Name>;user id=<username>;Password=<password>;" -provider Microsoft.EntityFrameworkCore.SqlServer -outputDir <Output Directory name> -context <context name>` - Its is mandatory to provide connectio string and the provider rest parameters are optional

## .NET core CLI COMMANDS (specially VSCODE users)
- Run following commands in your Data Layer project in the vscode terminal/gitbash/Command prompt)
- `dotnet add package Microsoft.EntityFrameworkCore.SqlServer`
- `dotnet add package Microsoft.EntityFrameworkCore.Design`
- `dotnet add package Microsoft.EntityFrameworkCore.Tool`
- `dotnet ef` - to check EF is installed
- `dotnet ef -h` -See the EF help commands
- `dotnet ef dbcontext scaffold -h` - see if help about EF Db Context Scaffold commands
- `dotnet ef dbcontext scaffold -connection "Server=<server name>;Database=<Db Name>;user id=<username>;Password=<password>;" -provider Microsoft.EntityFrameworkCore.SqlServer -outputDir <Output Directory name> -context <context name>` - to get all Entities mapped from database objects to C# classes.


[Reference](https://www.entityframeworktutorial.net/efcore/entity-framework-core.aspx)
