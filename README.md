
# CRUDApp

CRUDApp, a console application developed in .NET 8, stands as a testament to the seamless integration of C# and ADO.NET for robust database operations.

Designed with a focus on simplicity and efficiency, this application empowers users to perform essential CRUD (Create, Read, Update, Delete) operations on a SQL database.




![Project Structrue](https://cdn.dribbble.com/users/1241808/screenshots/2940913/hrp_sddrib.gif)

## Acknowledgements

 - [ADO.NET Overview](https://learn.microsoft.com/en-us/dotnet/framework/data/adonet/ado-net-overview)
 - [ Create a simple C# console app in Visual Studio](https://learn.microsoft.com/en-us/visualstudio/get-started/csharp/tutorial-console?view=vs-2022)
 - [SQL Overview](https://www.w3schools.com/sql/sql_syntax.asp)


# Project Structure & High-Level Overview

A cross-platform C# application. The CRUDApp solution contains CRUDApp.ConsoleApp of type C# Console Application.

`[CRUDApp.ConsoleApp]` is the core project of this solution containing 1. `ConnectionManager` 2. `IDataAccess` & 3. `DataAccess` in Logic folder. 

`[ appsettings.json ]` contains configuration settings for application, such as database connection. Modify it according to you.


 
## Demo
This is a simple representation to showcase the structure of a project dealing with tasks. 
![Project Structrue](https://cdn.dribbble.com/users/1894420/screenshots/14032021/media/a85f637f1eb4cd5efdd307f9760472a1.gif)
**Project Prerequisites:**

 - Other:
   - DotNet SDK 8.0 or Above
   - Good Internet Connection

 - IDE:
   - Visual Studio 2022
   - Visual Studio Code
   - JetBrains Rider 2023

 - Packages:
     - Microsoft.Data.SqlClient `Version="5.1.2" `
     - Microsoft.Extensions.Configuration `Version="8.0.0`
     - Microsoft.Extensions.Configuration.Json `Version="8.0.0`


     
### Contribute
As a free and open-source project, we are very grateful to everyone who helps us to develop this project.
