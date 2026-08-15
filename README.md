# Assignment Management System

A web-based **Assignment Management System** built with **ASP.NET Core Web API, Entity Framework Core, PostgreSQL, JWT, and HTML/CSS/JavaScript**.

> **Status:** Core backend and frontend functionality completed. Some advanced features are still pending.

## 🚀 Features

- 👨‍🏫 **Teacher:** Create classes, subjects, and assignments, and grade student submissions with marks and feedback.
- 👨‍🎓 **Student:** View available assignments and submit answers.
- 🔐 **Authentication:** JWT-based authentication and role-based authorization.
- 📝 **Assignment Management:** Create, view, update, and delete assignments.
- 📤 **Submissions:** Students can submit answers and teachers can review and grade them.
- 🏫 **Class & Subject Management:** CRUD APIs for classes and subjects.
- 👥 **User Management:** User-related API functionality.
- 🗄️ **Database:** PostgreSQL with Entity Framework Core.
- 📖 **API Documentation:** Swagger/OpenAPI endpoints.
- 🚪 **Frontend:** Login, Teacher Dashboard, Student Dashboard, and Logout.

## 🛠️ Technologies

* **Backend:** C#, ASP.NET Core Web API
* **Database:** PostgreSQL
* **ORM:** Entity Framework Core
* **Authentication:** JWT
* **Frontend:** HTML, CSS, JavaScript
* **API Testing:** Swagger
* **Version Control:** Git & GitHub

## 📂 Project Structure

```text
AssignmentManagementSystem/
├── Controllers/
├── Data/
├── Models/
├── DTOs/
├── Migrations/
├── Frontend/
│   ├── index.html
│   ├── dashboard.html
│   ├── teacher-dashboard.html
│   ├── app.js
│   └── style.css
├── Program.cs
├── appsettings.json
└── AssignmentManagementSystem.slnx
```

## ▶️ How to Run

1. Clone the repository:

```bash
git clone https://github.com/YOUR_USERNAME/AssignmentManagementSystem.git
```

2. Configure your PostgreSQL connection in `appsettings.json`.

3. Apply migrations:

```bash
dotnet ef database update
```

4. Run the ASP.NET Core API.

5. Open Swagger:

```text
https://localhost:7071/swagger
```

6. Open the frontend:

```text
Frontend/index.html
```

> Make sure the backend API is running before opening the frontend.

## 🔑 Demo Credentials

### 👨‍🏫 Teacher

```text
Email: rahim.updated@gmail.com
Password: 123456
Role: Teacher
```

### 👨‍🎓 Student

```text
Email: sakib@gmail.com
Password: 123456
Role: Student
```

## 📌 Current Status

### Completed

* [x] Authentication & Authorization
* [x] Assignment Management
* [x] Student Submission
* [x] Teacher Submission Viewing
* [x] Grading & Feedback
* [x] Student & Teacher Dashboards
* [x] PostgreSQL Integration
* [x] Swagger API
* [x] Frontend Integration

### Future Improvements

* [ ] Complete Admin Dashboard
* [ ] File Upload
* [ ] Advanced UI
* [ ] Testing
* [ ] Production Deployment

## 👨‍💻 Author

**Md Alif Hossain Parvez**

