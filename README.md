# AssignmentManagementSystem

Full-stack Assignment & Submission Management System built with ASP.NET Core Web API (.NET 10) and PostgreSQL (via EF Core), paired with a vanilla HTML/CSS/JS frontend. Implements role-based access control (Teacher/Student) using JWT authentication and BCrypt password hashing.

Features: Teachers create classes, subjects, and assignments, then grade student submissions with marks and feedback. Students view assigned work and submit answers before deadlines. Full CRUD across Users, Classes, Subjects, Assignments, and Submissions, with Swagger-documented endpoints.

Setup: Clone the repo, add a PostgreSQL connection string and JWT secret in appsettings.json, run dotnet ef database update to apply migrations, run dotnet run to start the API, then open the frontend HTML files to use the app.

Demo Credentials:
Teacher — Email: rahim.updated@gmail.com, Password: 123456
Student — Email: sakib@gmail.com, Password: 123456
