# **Todo Application with CQRS Pattern**

This repository demonstrates a **Todo Application** built using the **CQRS (Command Query Responsibility Segregation)** pattern in **ASP.NET Core**. The application showcases a clean separation of responsibilities for handling commands (write operations) and queries (read operations), making the architecture scalable, maintainable, and extensible.

---

## **Features**

- **Command Operations**:
  - Add a new todo item.

- **Query Operations**:
  - Fetch all todo items.
  - Filter todo items by completion status.

- **CQRS Pattern**:
  - Separate command and query models with dedicated handlers.
  - Optimized operations for scalability.

- **In-Memory Database**:
  - Lightweight storage for quick testing and development.

---

## **Getting Started**

### **Prerequisites**
Ensure you have the following installed:
- [.NET 6 SDK or later](https://dotnet.microsoft.com/download)
- [Visual Studio](https://visualstudio.microsoft.com/) or any IDE of your choice.

---

### **Setup Instructions**

1. **Clone the Repository**:
   ```bash
   git clone https://github.com/MuhammadSohailNazar/TodoCQRS.git
   cd todoCQRS
