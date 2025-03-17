# MVC Movie Application

A .NET Core MVC application for managing movies, built with ASP.NET Core 8.0 and Entity Framework Core.

## Prerequisites

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [Visual Studio 2022](https://visualstudio.microsoft.com/vs/) or [Visual Studio Code](https://code.visualstudio.com/)
- SQL Server LocalDB or SQL Server

## Getting Started

### Clone the Repository

```bash
git clone [https://github.com/ketap2/MvcMovie.git]
cd MvcMovie
```

### Database Setup

The application uses SQL Server LocalDB. The connection string is already configured in `appsettings.json`. The database will be automatically created and seeded when you run the application for the first time.

### Running the Application

1. Using .NET CLI:

```bash
dotnet restore
dotnet build
dotnet run
```

2. Using Visual Studio:

- Open the `MvcMovie.sln` solution file
- Press F5 or click the "Run" button

The application will be available at:

- [https://localhost:7241](https://localhost:7241)
- [http://localhost:5241](http://localhost:5241)

## Features

- View list of movies
- Add, edit, and delete movies
- Search movies by title
- Filter movies by genre
- Sort movies by various properties

## Project Structure

- **Controllers/**: Contains MVC controllers
  - `HomeController.cs`: Handles home page requests
  - `MoviesController.cs`: Manages movie-related operations

- **Models/**: Contains data models and view models
  - `Movie.cs`: Movie entity model
  - `MovieGenreViewModel.cs`: View model for movie listings
  - `SeedData.cs`: Initial database seed data

- **Views/**: Contains Razor views
  - `Home/`: Home page views
  - `Movies/`: Movie-related views
  - `Shared/`: Shared layouts and partial views

- **Data/**: Contains database context
  - `MvcMovieContext.cs`: Entity Framework database context

## Technologies Used

- ASP.NET Core 8.0
- Entity Framework Core 8.0
- SQL Server LocalDB
- Bootstrap (for styling)

## Development Notes

- The application uses Entity Framework Core with SQL Server
- Database migrations are automatically applied on startup
- Initial seed data is provided in `SeedData.cs`
