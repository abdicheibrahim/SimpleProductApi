# 🛒 SimpleProductApi

A clean and modular ASP.NET Core Web API project for managing products, following best practices such as the Repository Pattern, Service Layer, and Unit of Work.

---

## 🧱 Tech Stack

- ASP.NET Core 8
- Entity Framework Core
- SQLite (easy to switch to SQL Server or PostgreSQL)
- Repository Pattern
- Unit of Work Pattern
- Service Layer
- AutoMapper
- Swagger UI
- JWT Authentication

---

## 🚀 How to Run

1. **Clone the repo:**

```bash
git clone https://github.com/abdicheibrahim/SimpleProductApi.git
cd SimpleProductApi
```

2. **Update the connection string in `appsettings.json`** if needed

3. **Run the application:**

```bash
dotnet run
```

4. **Access Swagger UI:**

```
https://localhost:5001/swagger
```

---

## 🔐 Authentication (JWT)

- Register a new user: `POST /api/auth/register`
- Login to get a token: `POST /api/auth/login`
- Copy the token and add it as a Bearer token to call protected endpoints like:
  - `GET /api/products`
  - `POST /api/products`

---

## 🎯 About the Project

This project is part of my journey to become a freelance ASP.NET Core developer.  
It follows clean architecture principles and will soon be connected to a Blazor Server frontend for full-stack functionality.

> Created by [Ibrahim Abdiche](https://github.com/abdicheibrahim)  
> Feel free to fork, star ⭐, or contribute!