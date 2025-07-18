# 🧱 InkLink Backend Setup (PostgreSQL + EF Core)

_A documentation snapshot from collaborative development with Copilot._

## 🧰 Tech Stack Overview

- **Frontend:** Blazor Server (real-time capabilities)
- **Backend:** ASP.NET Core Web API
- **Realtime:** SignalR (story co-writing sessions)
- **Database:** PostgreSQL with EF Core (via Npgsql)
- **Authentication:** ASP.NET Identity or custom auth (TBD)

---

## 📦 Project Structure


---

## 🐘 PostgreSQL Dev Setup

### 1. Install
- Use official installer via [postgresql.org](https://www.postgresql.org/download/windows)
- Include: Server + pgAdmin + CLI tools

### 2. Create Database in pgAdmin
- Name: `InkLinkDb`
- Owner: `postgres`
- Port: `5432`

### 3. Connection String (in `appsettings.json`)
```json
"ConnectionStrings": {
  "DefaultConnection": "Host=localhost;Port=5432;Database=InkLinkDb;Username=postgres;Password=your_password"
}
