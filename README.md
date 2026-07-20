# MusteriDb Solution (Console App & Web API)



## 1. Short Description

This solution consists of two projects designed to manage customer data. It started as a C# Console Application demonstrating traditional ADO.NET and modern Entity Framework Core technologies, and has now been expanded with an ASP.NET Core Web API project to expose these data operations over HTTP endpoints.



## 2. Purpose of the Project

The primary goal of this application is to practice and understand the interaction between a C# application and a relational database (Microsoft SQL Server). It provides hands-on experience with:

- ADO.NET and Entity Framework Core for data access.
- Developing RESTful APIs using ASP.NET Core Web API.
- Testing API endpoints via Swagger.



## 3. Technologies Used

- C#
- .NET 9
- ASP.NET Core Web API
- Microsoft SQL Server
- ADO.NET
- Entity Framework Core
- LINQ
- Swagger / OpenAPI



## 4. Learned and Applied Concepts

During the development of this project, the following concepts and technologies were applied:

- **ASP.NET Core Web API:**
  - Creating API Controllers and defining routing.
  - Handling HTTP methods (GET, POST, PUT, DELETE).
  - Setting up Dependency Injection (DI) for services and DbContext.
  - Testing endpoints using the built-in Swagger UI.

- **ADO.NET (Console App):**
  - Usage of `SqlConnection`, `SqlCommand`, and `SqlDataReader`.
  - Preventing SQL Injection with parameterized queries.
  - Basic CRUD operations and JOINs.

- **Entity Framework Core:**
  - Creating model classes (Code-First approach basis).
  - Defining `DbContext` and `DbSet`.
  - Fetching, filtering, adding, and removing data.
  - Fetching related data (Eager Loading with `Include`).



## 5. Project Structure

The solution is organized into multiple projects as follows:

```text
MusteriDbConsoleApp (Solution Root)
├── MusteriDbConsoleApp            # The original Console Application
│   ├── Data, Models, Services     # Core logic and EF/ADO.NET implementations
│   ├── Examples ADO.NET           # Practical ADO.NET code examples
│   ├── Examples EF Core           # Practical EF Core code examples
│   └── Program.cs
├── MusteriDbWebApi                # The new ASP.NET Core Web API project
│   ├── Controllers                # API Endpoints (e.g., MusteriController)
│   ├── Data                       # EF Core database context
│   ├── Models                     # Entity models for the API
│   ├── Services                   # Business logic and database operations
│   └── Program.cs                 # API Entry point and DI container configuration
└── MusteriDbConsoleApp.sln        # Visual Studio Solution File
```



## 6. Database Structure

Both projects connect to a database named `MusteriDB` with the following relationships between tables:

- **Musteriler:** Stores basic customer information.
- **MusteriAdresleri:** Contains address information (related to the Musteriler table).
- **MusteriIletisimBilgileri:** Stores contact details (related to the Musteriler table).

Proper Primary Key and Foreign Key relationships are established between these tables.



## 7. Setup Requirements

To run these projects in your local environment, you need to ensure the following prerequisites are met:

- **Microsoft SQL Server** must be installed and running on your machine.
- The `MusteriDB` database and related tables must be created beforehand (Automatic migrations are not applied).
- You must verify and update the database Connection String located in `appsettings.json` (for the Web API) and `Data/MusteriDbContext.cs` (for the Console App) to match your local SQL Server settings.
- Required NuGet packages must be successfully restored.
- It is recommended to open the project using Visual Studio (or a suitable IDE) via the `MusteriDbConsoleApp.sln` file.



## 8. How to Run the Project

1. Open `MusteriDbConsoleApp.sln` in Visual Studio.
2. Right-click the solution in the Solution Explorer and select "Restore NuGet Packages", or simply build the project.
3. Check the database connection strings in both projects and ensure they are compatible with your environment.
4. **To run the Web API:**
   - Right-click the `MusteriDbWebApi` project and select **"Set as Startup Project"**.
   - Run the project using **Start (F5)** or **Start Without Debugging (Ctrl+F5)**.
   - Your browser will open the Swagger UI where you can test the API endpoints.
5. **To run the Console App:**
   - Right-click the `MusteriDbConsoleApp` project and select **"Set as Startup Project"**.
   - Run the project to see the console output.



## 9. NuGet Packages Used

The following key NuGet packages are used across the solution:

- `Microsoft.EntityFrameworkCore`
- `Microsoft.EntityFrameworkCore.SqlServer`
- `Microsoft.EntityFrameworkCore.Tools`
- `Microsoft.Data.SqlClient`
- `Swashbuckle.AspNetCore` (for Web API Swagger UI)



## 10. Current Status of the Project

This project is an evolving professional learning and practice repository. It has successfully transitioned from a standalone console application to a multi-project solution featuring a functional RESTful Web API, demonstrating the core integration of C#, SQL Server, and ASP.NET Core.



## 11. Future Enhancements

Potential improvements that could be made to take the project further:

- Implementing design patterns like Repository and Unit of Work across the solution.
- Adding Exception Handling middleware and Logging infrastructure (e.g., NLog, Serilog) to the API.
- Implementing Authentication and Authorization (e.g., JWT) in the Web API.
- Enabling automatic Migrations with the Code-First approach.
- Improving performance by using asynchronous methods (e.g., `ToListAsync`, `SaveChangesAsync`) everywhere.
