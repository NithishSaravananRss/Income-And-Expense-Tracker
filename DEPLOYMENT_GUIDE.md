# Income and Expenses Tracker - Deployment Guide

## Overview
This application has been updated to support easy deployment without hardcoded file paths. The database will be automatically created on first run.

## Key Changes Made

### 1. **DatabaseHelper Class**
- Centralized database connection management
- Automatic database creation if not found
- Uses `|DataDirectory|` for relative path resolution
- Database stored in user's AppData folder: `%AppData%\IncomeandExpensesTracker\`

### 2. **Database Auto-Creation**
- On first run, the application will automatically:
  - Create the database folder in AppData
  - Create a new `expense.mdf` database file
  - Set up all required tables (users, categories, income, expenses)
  - Insert a default admin user (username: `admin`, password: `admin`)
  - Insert sample categories

### 3. **Updated All Forms**
All forms now use `DatabaseHelper.GetConnectionString()` instead of hardcoded paths:
- Form1.cs (Login)
- RigsterForm.cs (Registration)
- CategoryForm.cs
- IncomeForm.cs
- ExpensesForm.cs
- DashboardForm.cs
- categoryData.cs
- IncomeData.cs
- ExpensesData.cs

## Deployment Instructions

### Option 1: Publish with ClickOnce
1. In Visual Studio, right-click the project and select **Publish**
2. Choose **Folder** as the target
3. Select your publish location
4. Click **Publish**
5. Share the published folder with users

### Option 2: Build and Copy
1. Build the project in **Release** mode
2. Navigate to `bin\Release\` folder
3. Copy all files to deployment location
4. Run `IncomeandExpensesTracker.exe`

### Option 3: Create Setup Project
1. Add a new **Setup Project** to your solution
2. Add project output from IncomeandExpensesTracker
3. Build the setup project
4. Distribute the generated MSI file

## Default Login Credentials
- **Username**: admin
- **Password**: admin

?? **Important**: Change the admin password after first login!

## Database Location
The database will be created at:
```
C:\Users\[YourUsername]\AppData\Roaming\IncomeandExpensesTracker\expense.mdf
```

## Troubleshooting

### Issue: "Cannot attach database" error
**Solution**: Make sure SQL Server LocalDB is installed
- Download from: https://learn.microsoft.com/en-us/sql/database-engine/configure-windows/sql-server-express-localdb

### Issue: Database not being created
**Solution**: 
1. Check if the AppData folder has write permissions
2. Check Windows Event Viewer for detailed error messages
3. Run the application as Administrator (one time)

### Issue: Tables not found
**Solution**: Delete the database file and let the application recreate it:
1. Close the application
2. Delete: `%AppData%\IncomeandExpensesTracker\expense.mdf` and `expense_log.ldf`
3. Restart the application

## Features

### User Management
- User registration with password validation
- Secure login system
- Username uniqueness validation

### Category Management
- Create custom categories for Income and Expenses
- Mark categories as Active/Inactive
- Edit and delete categories

### Income Tracking
- Record income transactions
- Categorize income
- Track income by date
- View income history

### Expense Tracking
- Record expense transactions
- Categorize expenses
- Track expenses by date
- View expense history

### Dashboard
- Today's income and expenses
- Yesterday's summary
- This month's totals
- This year's totals
- Overall totals
- Visual representation of financial data

## System Requirements
- Windows 7 or later
- .NET Framework 4.7.2 or later
- SQL Server LocalDB (included with Visual Studio or available as standalone)
- Minimum 100 MB free disk space

## Notes for Developers

### Database Schema
The database contains 4 tables:
- **users**: User authentication
- **categories**: Income/Expense categories
- **income**: Income transactions
- **expenses**: Expense transactions

### Adding New Features
When adding database queries, always use:
```csharp
using (SqlConnection connect = new SqlConnection(DatabaseHelper.GetConnectionString()))
{
    // Your code here
}
```

### Backup Database
To backup user data, copy the database files from:
```
%AppData%\IncomeandExpensesTracker\
```

## License
[Your License Here]

## Support
For issues and feature requests, please contact [Your Contact Info]
