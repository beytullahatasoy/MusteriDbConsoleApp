# MusteriDbConsoleApp

## 1. Short Description
This project is a C# Console Application designed to manage customer data. It demonstrates how to access and manage data using both traditional ADO.NET and modern Entity Framework Core technologies within the same project.

## 2. Purpose of the Project
The primary goal of this application is to practice and understand the interaction between a C# application and a relational database (Microsoft SQL Server). It provides hands-on experience with both ADO.NET and Entity Framework Core, illustrating the differences and use cases of each approach.

## 3. Technologies Used
- C#
- .NET 9
- Microsoft SQL Server
- ADO.NET
- Entity Framework Core
- LINQ

## 4. Learned and Applied Concepts
During the development of this project, the following concepts and technologies were applied:
- **ADO.NET:**
  - Usage of `SqlConnection`, `SqlCommand`, and `SqlDataReader`.
  - Preventing SQL Injection with parameterized queries.
  - Basic CRUD (Create, Read, Update, Delete) operations.
  - JOIN operations between tables.
- **Entity Framework Core:**
  - Creating model classes (Code-First approach basis).
  - Defining `DbContext` and `DbSet`.
  - Fetching, filtering, and adding data (`ToList`, `FirstOrDefault`, `Add`, `Remove`).
  - Saving database changes (`SaveChanges`).
  - Fetching related data (Eager Loading with `Include`).
- Database operations are separated into a dedicated `MusteriService` class for modularity, instead of keeping everything in `Program.cs`.

## 5. Project Structure
The project is organized in a clean and understandable structure as follows:

```text
MusteriDbConsoleApp
├── Data
│   └── MusteriDbContext.cs        # EF Core database context class
├── Models
│   ├── Musteri.cs                 # Customer entity model
│   ├── MusteriAdresi.cs           # Customer address entity model
│   └── MusteriIletisimBilgisi.cs  # Customer contact info entity model
├── Services
│   └── MusteriService.cs          # Service handling database operations
├── Examples ADO.NET               # Practical ADO.NET code examples
├── Examples EF Core               # Practical EF Core code examples
└── Program.cs                     # Entry point of the application
```

## 6. Database Structure
The application uses a database named `MusteriDB` with the following relationships between tables:
- **Musteriler:** Stores basic customer information.
- **MusteriAdresleri:** Contains address information (related to the Musteriler table).
- **MusteriIletisimBilgileri:** Stores contact details (related to the Musteriler table).
Proper Primary Key and Foreign Key relationships are established between these tables.

## 7. Setup Requirements
To run this project in your local environment, you need to ensure the following prerequisites are met:
- **Microsoft SQL Server** must be installed and running on your machine.
- The `MusteriDB` database and related tables must be created beforehand (Automatic migrations are not applied).
- You must verify and update the database Connection String located in `Data/MusteriDbContext.cs` or related service classes to match your local SQL Server settings.
- Required NuGet packages must be successfully restored.
- It is recommended to open the project using Visual Studio (or a suitable IDE) via the `MusteriDbConsoleApp.sln` file.

## 8. How to Run the Project
1. Open the project in Visual Studio.
2. Right-click the solution in the Solution Explorer and select "Restore NuGet Packages", or simply build the project.
3. Check the database connection string and ensure it is compatible with your environment.
4. Make sure `MusteriDbConsoleApp` is set as the Startup Project.
5. Run the project using **Start (F5)** or **Start Without Debugging (Ctrl+F5)**.

## 9. NuGet Packages Used
The following NuGet packages are used for Entity Framework Core and SQL Server connectivity:
- `Microsoft.EntityFrameworkCore`
- `Microsoft.EntityFrameworkCore.SqlServer`
- `Microsoft.EntityFrameworkCore.Tools`
- `Microsoft.Data.SqlClient`

## 10. Description of Examples Folders
The `Examples ADO.NET` and `Examples EF Core` folders contain `.txt` files with practical code snippets created during the learning process. These files demonstrate various database operations and serve as a reference for applying theoretical knowledge in practice.

## 11. Current Status of the Project
This project is not a large-scale enterprise system; rather, it is a professional learning and practice project aimed at understanding the core C# and SQL Server integration, as well as highlighting the differences between ADO.NET and Entity Framework Core. The foundation is complete and the application works as intended.

## 12. Future Enhancements
Potential improvements that could be made to take the project further:
- Implementing design patterns like Repository and Unit of Work.
- Creating an interactive console UI (e.g., getting inputs through user menus).
- Adding Exception Handling mechanisms and Logging infrastructure (e.g., NLog, Serilog).
- Enabling automatic Migrations with the Code-First approach (integrating the database creation process into the project).
- Improving performance by using asynchronous methods (e.g., `ToListAsync`, `SaveChangesAsync`).
