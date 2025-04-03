# Moral Support Tasks

**Moral Support Tasks** is a modular task management tool built with Clean Architecture and ASP.NET Core. It's the first core module of the [Moral Support Suite](https://github.com/MoralSupportStudios), designed to empower small businesses and property managers with lightweight, modern software tools.

This MVP includes:

- ✅ Task creation, editing, and deletion  
- ✅ Razor Pages frontend (runs locally, not hosted on GitHub Pages)  
- ✅ Clean Architecture structure (Domain, Application, Infrastructure, Web)  
- ✅ Filter and display tasks by status (Pending, In Progress, Completed)  
- ✅ Local-first deployment with CI/CD via GitHub Actions  
- 🔒 Future support for shared authentication and modular integration  

---

## 🛠️ Tech Stack

- **Frontend:** ASP.NET Core Razor Pages  
- **Backend:** Clean Architecture (Domain → Application → Infrastructure → Web)  
- **Database:** SQL Server (local dev) → Supabase (planned)  
- **Deployment:** Local (future: self-hosted or cloud)  
- **Testing:** NUnit  

---

## 🧱 Project Structure

```
MoralSupport.Tasks.sln
├── MoralSupport.Tasks.Domain/         # Entities & Enums
├── MoralSupport.Tasks.Application/    # Interfaces & Business Logic
├── MoralSupport.Tasks.Infrastructure/ # Repositories & EF DbContext
└── MoralSupport.Tasks.Web/            # Razor UI + Configuration
```

---

## 🧪 Developer Setup Guide

1. Clone the repo  
2. In `MoralSupport.Tasks.Web`, create a new file named:
   ```
   appsettings.Development.json
   ```
3. Paste your **local SQL Server connection string**, e.g.:
   ```json
   {
     "ConnectionStrings": {
       "LocalConnection": "Server=(localdb)\\MSSQLLocalDB;Database=MoralSupport;Trusted_Connection=True;MultipleActiveResultSets=true"
     }
   }
   ```
4. Open **Package Manager Console** and run:
   ```powershell
   Update-Database -StartupProject MoralSupport.Tasks.Web
   ```
5. Run the app from Visual Studio or with:
   ```bash
   dotnet run --project MoralSupport.Tasks.Web
   ```

---

## 🔐 Connection String Management

- `appsettings.json` contains a placeholder or empty value  
- `appsettings.Development.json` is ignored in `.gitignore` and should contain your actual dev connection string  
- Future hosting environments can override via environment variables or cloud secrets  

---

## 🧭 Roadmap & Future Plans

- ✳️ Supabase migration for shared cloud database access  
- 👥 Authentication via Moral Support Auth  
- 📊 Reporting, notifications, and shared views  
- 🔗 Integration with Moral Support Finance and Moral Support Documents  
- 💡 Role-based filtering and dashboard views for teams  

---

## 🧍 Team Notes

If you're on the Moral Support Studios team (hi Nubchulubs12 👋):

- Use GitHub Projects to track tasks  
- Submit Pull Requests and request reviews before merging  
- Keep logic in Domain and Application layers where possible — frontend should be mostly passive  
- Follow Clean Architecture patterns and keep services injectable
