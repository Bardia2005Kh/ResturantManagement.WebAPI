🍽️ RestaurantManagement.WebAPI

A Restaurant Management Web API built with ASP.NET Core 8 and Entity Framework Core (Code First).
This project provides a robust backend system for managing restaurants, tables, orders, customers, payments, and menus with categories.

🚀 Features

Full CRUD operations for all entities:

Order, Table, Customer, Payment, MenuItem, Category

Query menu items by category (e.g. get all Pizzas or Burgers)

Entity relationships implemented using EF Core (One-to-One / One-to-Many)

Interactive API documentation via Swagger

DTOs & Object Mapping with AutoMapper

🛠️ Technologies Used

ASP.NET Core 8 (Web API)

Entity Framework Core (Code First)

SQL Server

Swagger / Swashbuckle

AutoMapper

DTOs for clean data transfer

⚙️ Setup & Run

Clone the repository:

git clone https://github.com/YOUR-USERNAME/RestaurantManagement.WebAPI.git
cd RestaurantManagement.WebAPI


Update the connection string in appsettings.json to point to your SQL Server.

Run database migrations:

dotnet ef database update


Run the application:

dotnet run


Open Swagger UI in your browser at:
👉 https://localhost:5001/swagger

📌 Roadmap

🔐 Authentication & Authorization (JWT)

📊 Reporting & Analytics for Orders & Sales

🛒 Advanced Filtering & Search for MenuItems

🎯 Project Goal

This is a practice project to improve my skills in ASP.NET Core Web API, EF Core, and RESTful API design.
In future updates, features such as authentication and more advanced business logic will be added.
