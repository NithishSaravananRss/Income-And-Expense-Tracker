# Income and Expenses Tracker 💰

A Windows Forms application built in C# (.NET Framework) to manage personal income and expenses.

---

## 🚀 Features
- User registration and login  
- Add, update, and delete income/expense entries  
- Categorize transactions (Income / Expense)  
- Simple and user-friendly interface  
- Local database using SQL Server LocalDB (`.mdf` file)  

---

## 🛠️ Requirements
- **Visual Studio** (Community/Professional/Enterprise)  
- **.NET Framework Developer Pack**  
- **SQL Server LocalDB** (comes with Visual Studio)  

---

## ⚙️ How to Set Up and Run This Project

1. **Download or Clone the Project**  
   - Clone:  
     ```bash
     git clone https://github.com/yourusername/IncomeandExpensesTracker.git
     ```  
   - Or download the ZIP and extract it.

2. **Open the Project in Visual Studio**  
   - Open `IncomeandExpensesTracker.sln`.

3. **Create a Database in Server Explorer**  
   - Open **Server Explorer** in Visual Studio.  
   - Right-click **Data Connections → Add Connection**.  
   - Choose **Microsoft SQL Server Database File (SqlClient)**.  
   - Enter the database name as **expense** and create it.

4. **Copy the Connection String**  
   - Right-click the new `expense.mdf` database → **Properties**.  
   - Copy the **Connection String** shown there.

5. **Update the Project Code**  
   - Open each form file where a `SqlConnection` is used (for example, `Form1.cs`, `RigsterForm.cs`, `IncomeForm.cs`, `ExpenseForm.cs`).  
   - Replace the connection with the copied string, like this:  
     ```csharp
     SqlConnection connect = new SqlConnection(@"your-copied-connection-string-here");
     ```

6. **Run the Database Script**  
   - Open the file `SQLQUERY1.SQL` included in the project.  
   - Execute it in Visual Studio (Server Explorer query window) or SQL Server Management Studio to create all required tables (`users`, `income`, `expenses`, `categories`).

7. **Build and Run the Project**  
   - Press **F5** (Debug) or **Ctrl + F5** (Run without Debug).  
   - First **register a new user**, then **log in** with that account.  

---

## 📂 Project Structure
- `IncomeandExpensesTracker.sln` → Solution file  
- `Form1.cs` → Login form  
- `RigsterForm.cs` → Registration form  
- `IncomeForm.cs` → Income management  
- `ExpenseForm.cs` → Expense management  
- `SQLQUERY1.SQL` → Database schema  

---


