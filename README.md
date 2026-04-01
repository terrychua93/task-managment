# 📌 TaskApp – Task Management System

A full-stack task management application built with **Blazor** and **ASP.NET Core Web API**, demonstrating clean UI design, component-based architecture, and API-driven data flow.

---

## 🛠 Tech Stack

- ⚛️ **Blazor** – Component-based UI framework  
- ⚙️ **ASP.NET Core Web API** – Backend REST API  
- 🗄️ **Entity Framework Core** – ORM for database access  
- 🧠 **C#** – Core application logic  
- 🎨 **Tailwind CSS** – Utility-first styling  
- 🔗 **HTTP Client** – Communication between frontend and backend  

---

## ✨ Features

- 🧾 Create new tasks  
- 📋 View task list  
- ✅ Mark tasks as completed  
- 🗑️ Delete tasks  
- 🔍 Filter tasks (All / Completed / Pending)  
- 🧪 Form validation using DataAnnotations  
- 🎨 Responsive UI with Tailwind CSS  
- ⚡ API-driven data fetching and updates  
- 🧩 Reusable Blazor components (TaskCard, TaskForm, TaskFilter)  

---

## 🧠 Design & Architecture

- Separation of concerns between frontend and backend  
- Blazor components used for modular UI design  
- REST API handles all data operations  
- Service layer used for API communication  
- Clean and maintainable component structure  
- Minimal business logic inside UI layer  

---

## 🧾 Validation Rules

- **Title** → Required  
- **Description** → Required (based on model configuration)  
- Validation handled using:
  - `EditForm`
  - `DataAnnotationsValidator`
  - `ValidationMessage`

---

## 📷 Screenshots

<img width="1338" height="862" alt="image" src="https://github.com/user-attachments/assets/a337799f-833b-448c-9996-07500eb0f222" />

---

## 🚀 Project Setup

### 1. Clone the repository

```bash
git clone <your-repo-url>
cd TaskApp
