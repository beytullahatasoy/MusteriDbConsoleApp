# MusteriDb Project (Console & Web API)

## Purpose of the Project

This project was developed to learn and practice SQL Server database operations using C#. Initially, a Console Application was created using ADO.NET and Entity Framework Core. Later, this structure was expanded into an ASP.NET Core Web API project to handle external HTTP requests.

## Technologies Used

- C# & .NET 9
- ASP.NET Core Web API
- Microsoft SQL Server
- ADO.NET & Entity Framework Core
- Swagger (For API testing)

## Project Structure

The solution contains two separate projects:

```text
MusteriDbConsoleApp (Solution)
├── MusteriDbConsoleApp            # Console project for ADO.NET and EF Core practice
│   ├── Data, Models, Services     # Database connection and entity models
│   └── Examples                   # Basic SQL and EF Core code examples
└── MusteriDbWebApi                # Web API project (Added later)
    ├── Controllers                # Endpoints handling API requests
    ├── Data                       # EF Core DbContext class
    └── Models                     # Entity classes representing database tables
```

## Implemented Features / API Endpoints

Basic CRUD (Create, Read, Update, Delete) operations were implemented on the Customer (`Musteriler`), Address (`MusteriAdresleri`), and Contact Information (`MusteriIletisimBilgileri`) tables.

The following endpoints can be tested via the Swagger UI in the Web API:

- `GET /api/musteri` — Retrieves a list of all customers
- `GET /api/musteri/{id}` — Retrieves a single customer by ID
- `POST /api/musteri` — Adds a new customer
- `PUT /api/musteri/{id}` — Updates existing customer information
- `DELETE /api/musteri/{id}` — Deletes a customer

## How to Run

1. Ensure that Microsoft SQL Server is installed on your computer and a database named `MusteriDB` (with the related tables) is created.
2. Open the project using Visual Studio (`MusteriDbConsoleApp.sln`).
3. Update the Connection Strings to match your local SQL Server instance:
   - For the API: `appsettings.json` inside the `MusteriDbWebApi` project.
   - For the Console: `Data/MusteriDbContext.cs` inside the `MusteriDbConsoleApp` project.
4. Right-click the `MusteriDbWebApi` project and select **"Set as Startup Project"**.
5. Press **F5** to run the project. You can easily test all endpoints from the Swagger screen that opens in your browser.
