# AssignmentManagementSystem
```markdown
# Assignment Management System

Full-stack Assignment & Submission Management System built with ASP.NET Core Web API (.NET 10) and PostgreSQL (via EF Core), paired with a vanilla HTML/CSS/JS frontend. Implements role-based access control (Teacher/Student) using JWT authentication and BCrypt password hashing.

## Features

- Teachers create classes, subjects, and assignments
- Teachers grade student submissions with marks and feedback
- Students view assigned work and submit answers before deadlines
- Full CRUD across Users, Classes, Subjects, Assignments, and Submissions
- Role-based authorization (Teacher-only vs. any authenticated user)
- JWT-based authentication with BCrypt password hashing
- Swagger-documented API endpoints

## Tech Stack

- **Backend:** ASP.NET Core Web API (.NET 10)
- **Database:** PostgreSQL (Npgsql + EF Core)
- **Auth:** JWT Bearer Authentication + BCrypt.Net
- **API Docs:** Swagger / Swashbuckle
- **Frontend:** HTML, CSS, vanilla JavaScript

## Setup

1. Clone the repo
   ```
   git clone https://github.com/a1ifhossain/AssignmentManagementSystem.git
   ```
2. Add a PostgreSQL connection string and JWT secret in `appsettings.json`
3. Apply database migrations
   ```
   dotnet ef database update
   ```
4. Start the API
   ```
   dotnet run
   ```
5. Open the frontend HTML files (`index.html`, `dashboard.html`, `teacher-dashboard.html`) in a browser to use the app

## Demo Credentials

| Role | Email | Password |
|---|---|---|
| 👨‍🏫 Teacher | rahim.updated@gmail.com | 123456 |
| 👨‍🎓 Student | sakib@gmail.com | 123456 |
```
