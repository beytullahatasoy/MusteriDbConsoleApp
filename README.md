# MusteriDb Project (Console & Web API)

## Purpose of the Project

This project was developed to learn and practice SQL Server database operations using C#. Initially, a Console Application was created using ADO.NET and Entity Framework Core. Later, this structure was expanded into an ASP.NET Core Web API project to handle external HTTP requests.

## Technologies Used

- C# & .NET 9
- ASP.NET Core Web API
- Microsoft SQL Server
- ADO.NET & Entity Framework Core
- OpenAPI (For API testing)

## Project Structure

The solution contains two separate projects:

```text
MusteriDbConsoleApp (Solution)
├── MusteriDbConsoleApp            # Console project for ADO.NET and EF Core practice
│   ├── Data, Models, Services     # Database connection, entity models, and business logic
│   └── Examples                   # Basic SQL and EF Core code examples
└── MusteriDbWebApi                # Web API project (Added later)
    ├── Controllers                # Endpoints handling API requests
    └── Data, Models, Services     # DbContext, models, and database operations
```

## Implemented Features / API Endpoints

Customer CRUD operations were implemented. Related address and contact information can be retrieved through the customer detail endpoint.

- `GET /api/musteriler`
- `GET /api/musteriler/{musteriId}`
- `GET /api/musteriler/{musteriId}/detay`
- `POST /api/musteriler`
- `PUT /api/musteriler/{musteriId}`
- `DELETE /api/musteriler/{musteriId}`

## How to Run

1. Ensure that Microsoft SQL Server is installed on your computer and a database named `MusteriDB` (with the related tables) is created.
2. Open the project using Visual Studio (`MusteriDbConsoleApp.sln`).
3. Update the Connection Strings to match your local SQL Server instance:
   - For the API: `appsettings.json` inside the `MusteriDbWebApi` project.
   - For the Console: `Data/MusteriDbContext.cs` inside the `MusteriDbConsoleApp` project.
4. Right-click the `MusteriDbWebApi` project and select **"Set as Startup Project"**.
5. Press **F5** to run the project. You can test the endpoints using OpenAPI tools or an HTTP client.
