# Task Management System – Backend API

📁 Repository: [https://github.com/James-debuging/TaskManagementAPI]

This repository contains the **ASP.NET Core Web API backend** for a Task Management System. It exposes CRUD endpoints for managing tasks in memory (no database) and supports pagination and filtering.

---

## 📦 Tech Stack

- ASP.NET Core 9.0
- C#
- In-memory data storage (thread-safe `ConcurrentDictionary`)
- Fluent validation using `[Required]` attributes
- Swagger / OpenAPI for API docs
- CORS enabled for frontend integration
- Azure App Service deployment

---

## 🚀 Getting Started (Local)

### 1. Clone the repo

```bash
git clone https://github.com/James-debuging/TaskManagementAPI.git
run code by Visual studio 2022
browse http://localhost:5001/swagger
