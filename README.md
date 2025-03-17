# MVC Movie Application

A .NET Core MVC application for managing movies, built with ASP.NET Core 8.0 and Entity Framework Core.

## Prerequisites

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- SQL Server LocalDB or SQL Server

For Ubuntu/Debian:

```bash
wget https://packages.microsoft.com/config/ubuntu/$(lsb_release -rs)/packages-microsoft-prod.deb -O packages-microsoft-prod.deb
sudo dpkg -i packages-microsoft-prod.deb
sudo apt-get update
sudo apt-get install -y mssql-server
```

For macOS (using Docker):

```bash
docker pull mcr.microsoft.com/mssql/server:2022-latest
docker run -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=YourStrong@Passw0rd" -p 1433:1433 mcr.microsoft.com/mssql/server:2022-latest
```

## Getting Started

### Clone the Repository

```bash
git clone [https://github.com/ketap2/MvcMovie.git]
cd MvcMovie
```

### Install Required Tools

```bash
# Install Entity Framework Core tools globally
dotnet tool install --global dotnet-ef
```

### Database Setup

Update the connection string in `appsettings.json` if you're not using LocalDB:

```json
"ConnectionStrings": {
    "MvcMovieContext": "Server=(localdb)\\mssqllocaldb;Database=MvcMovieContext-1;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True"
}
```

### Build and Run

```bash
# Restore dependencies
dotnet restore

# Build the project
dotnet build

# Run the migrations
dotnet ef database update

# Run the application
dotnet run
```

The application will be available at:

- [https://localhost:7241](https://localhost:7241)
- [http://localhost:5241](http://localhost:5241)

## Basic dotnet Commands

```bash
# Create a new migration
dotnet ef migrations add MigrationName

# Remove last migration
dotnet ef migrations remove

# Update database
dotnet ef database update

# Drop the database
dotnet ef database drop

# List available migrations
dotnet ef migrations list

# Clean build artifacts
dotnet clean

# Run tests (if you have test project)
dotnet test
```

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
