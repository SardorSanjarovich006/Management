# Management System

## 📊 Project Overview

**Management System** is a .NET-based application designed to manage core business entities and operations. The project follows a layered (Clean Architecture–style) structure to keep business logic, application logic, and infrastructure concerns separated.

---

## 🚀 Features

* Modular and scalable architecture
* Clear separation of concerns:

  * Client (UI / entry point)
  * Application (business use cases)
  * Domain (core models and rules)
  * Infrastructure (data access, external services)
* Ready for extension with new modules and features

---

## 🧱 Project Structure

```
Management
│
├── Management.Application
│   └── Services
│       └── ManagementService.cs
│
├── Management.Application1
│   └── (Additional application logic / experiments)
│
├── Management.Domain
│   └── Entities
│       └── BaseEntity.cs
│
├── Management.Infrastructure
│   └── Data
│       └── AppDbContext.cs
│
├── Management.Client
│   └── Program.cs
│
├── .gitignore
└── Management.slnx
```

---

## 🛠️ Technologies Used

* C#
* .NET 6 / .NET 7
* Visual Studio
* Git & GitHub

---

## ▶️ How to Run

1. Clone the repository:

```bash
git clone https://github.com/USERNAME/Management.git
```

2. Open `Management.slnx` in **Visual Studio**

3. Set `Management.Client` as **Startup Project**

4. Run the application

---

## 🧪 Example Usage

```csharp
var service = new ManagementService();
service.Run();
```

---

## ⚠️ Notes

* `Management.Application1` is kept as a separate module (testing or alternative implementation).
* `.gitignore.txt` is not required and can be safely removed.

---

## 🤝 Contribution

1. Fork the repository
2. Create a new branch (`feature/new-feature`)
3. Commit your changes
4. Open a Pull Request

---

## 📄 License

This project is for educational purposes.

---

## 👤 Author

**Sardor Sanjarovich**
