# TaskFlow API

![C#](https://img.shields.io/badge/C%23-Backend-blue)
![ASP.NET Core](https://img.shields.io/badge/ASP.NET%20Core-Web%20API-green)
![Status](https://img.shields.io/badge/Status-Completed-brightgreen)
![License](https://img.shields.io/badge/License-MIT-lightgrey)

---

## 🚀 About

**TaskFlow API** is a RESTful Web API built with **ASP.NET Core** and **C#** for task management.  
It demonstrates **Object-Oriented Programming (OOP) principles**, including **encapsulation**, **polymorphism**, and a **layered architecture** (DTO → Service → Repository → Domain).  

This project is a strong **portfolio piece** for backend developer roles and showcases clean architecture, role-based access, and professional API design.

---

## 🎬 Demo

![TaskFlow Demo](https://media.giphy.com/media/26xBI73gWquCBBCDe/giphy.gif)

---

## 🧩 Features

- **Create Task** (`POST /api/tasks/create`) – Admin/Manager only  
- **Read Tasks** (`GET /api/tasks`) – View all tasks  
- **Assign Task** (`POST /api/tasks/assign`) – Admin/Manager only  
- **Delete Task** (`DELETE /api/tasks/{id}`) – Remove tasks  
- **Role-Based Access**:
  - **Admin** – full access  
  - **Manager** – create and assign tasks  
  - **RegularUser** – read-only access

---

## 🏗 Architecture

TaskFlowApi
├── Controllers # API endpoints
├── Models # Domain models (TaskItem, User types)
├── DTOs # Data Transfer Objects (CreateTaskDto, AssignTaskDto)
├── Services # Business logic (TaskService)
├── Repositories # In-memory data storage
└── Program.cs # Application startup


- **DTOs** → public properties, transport only  
- **Domain Models** → encapsulation + business logic  
- **Services** → rules for creating and assigning tasks  
- **Repositories** → in-memory storage, easily replaceable with a database  

---

## 🧪 Getting Started

### Prerequisites
- [.NET 6 SDK](https://dotnet.microsoft.com/download/dotnet/6.0)  
- Visual Studio 2022 or VS Code  

### Run Locally
```bash
git clone https://github.com/yourusername/TaskFlowApi.git
cd TaskFlowApi
dotnet run

Open Swagger UI for testing endpoints:
https://localhost:{PORT}/swagger
