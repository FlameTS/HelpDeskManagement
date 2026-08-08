# HelpDesk Management System

A Help Desk Ticket Management System built using ASP.NET Core Web API, ASP.NET Core MVC, Entity Framework Core, SQL Server, Repository Pattern, xUnit and Moq.

## Technologies Used

- ASP.NET Core Web API
- ASP.NET Core MVC
- Entity Framework Core
- SQL Server
- Repository Pattern
- HttpClient
- xUnit
- Moq
- Git & GitHub

## Architecture

Browser
    ↓
ASP.NET Core MVC
    ↓
Service Layer / HttpClient
    ↓
ASP.NET Core Web API
    ↓
Repository Pattern
    ↓
Entity Framework Core
    ↓
SQL Server

## Features

- Create tickets
- View all tickets
- View ticket details
- Edit tickets
- Delete tickets
- Filter tickets by status
- Dashboard with ticket statistics
- REST API
- SQL Server database with EF Core migrations
- Repository Pattern
- Unit testing with xUnit and Moq

## Projects

### HelpDesk.Api
Provides REST API endpoints and handles database operations.

### HelpDesk.Mvc
Provides the user interface and communicates with the API through the Service Layer.

### HelpDesk.Tests
Contains unit tests using xUnit and Moq.

## Database

The application uses SQL Server with Entity Framework Core migrations.

## Running the Project

1. Clone the repository.
2. Open `HelpDeskManagement.slnx` in Visual Studio.
3. Configure the SQL Server connection string in `HelpDesk.Api/appsettings.json`.
4. Apply the EF Core migration.
5. Run the API and MVC projects.
6. Open the MVC application in the browser.

## Testing

Unit tests are implemented using xUnit and Moq.

The repository is mocked so tests do not require a live SQL Server connection.

## Author

Tarman Singh Sohal