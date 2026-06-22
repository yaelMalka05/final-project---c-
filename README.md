# final-project---c-
# Charity Organization Management API 🤝

## About The Project
A robust RESTful backend system designed to manage volunteers, tasks, and assignments for a charity organization. Built with an N-Tier architecture, this API seamlessly handles volunteer tracking, task categorization (by expertise, location, and urgency), and intelligent assignments, ensuring the organization runs smoothly and efficiently.

## Tech Stack
* **Framework:** .NET 8.0[cite: 32] / ASP.NET Core Web API
* **Language:** C#[cite: 32]
* **Database & ORM:** MS SQL Server (LocalDB)[cite: 19] with Entity Framework Core (Code-First Migrations)[cite: 21]
* **Authentication:** JWT (JSON Web Tokens) for secure endpoints[cite: 30]
* **Object Mapping:** AutoMapper for clean Entity-to-DTO conversions[cite: 31]
* **API Documentation:** Swagger / OpenAPI[cite: 15]

## Key Features
* **Volunteer Management:** Full CRUD operations for volunteers[cite: 14], including filtering, sorting, and linking them to their specific areas of expertise[cite: 36].
* **Task Management:** Create and track tasks with different urgency levels (Urgent, Middle, Calm)[cite: 33] and statuses (Open, Assigned, Completed)[cite: 34]. Includes filtering by date and location[cite: 13, 34].
* **Assignments:** Link volunteers to tasks and record completion reporting times[cite: 28, 29].
* **Security & Auth:** Secure login system generating JWT tokens with claims based on volunteer credentials[cite: 12, 30].
* **Custom Middlewares:** Includes custom pipeline behaviors, such as request logging and restricting modification actions (PUT/DELETE) during specific hours[cite: 15].

## Project Structure
The solution follows a clean N-Tier architecture:
1. **Entities:** Database models (`Volunteer`, `PossibleTask`, `Assignment`, `AreasOfExpertise`, `Feedback`)[cite: 19].
2. **DTOs:** Data Transfer Objects to shape API requests and responses[cite: 1, 2].
3. **Repository:** Data access layer implementing the Repository Pattern (`DataProject` DbContext)[cite: 16, 17, 18, 19].
4. **Service:** Business logic layer handling mapping, validation, and JWT generation[cite: 29, 30, 34, 36].
5. **Controllers (API):** The presentation layer exposing RESTful endpoints[cite: 11, 12, 13, 14].

## Getting Started

### Prerequisites
* [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
* SQL Server Express / LocalDB

### Installation & Setup

1. **Clone the repository:**
```bash
   git clone [https://github.com/yaelMalka05/final-project---c-.git]

```

2. **Restore dependencies:**
Navigate to the solution folder and run:

```bash
   dotnet restore

```

3. **Update the Database:**
Apply the EF Core migrations to create the database schema:

```bash
   dotnet ef database update --project repository --startup-project finalProject

```

4. **Run the API:**

```bash
   dotnet run --project finalProject

```

5. **Explore the API:**
Open your browser and navigate to the Swagger UI (usually at `https://localhost:<port>/swagger`) to test the endpoints interactively.
