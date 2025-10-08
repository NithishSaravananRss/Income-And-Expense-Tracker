# Income and Expenses Tracker - Quick Start

## ? What Was Fixed

### Problem
- Application had hardcoded database paths (C:\Users\hp\Desktop\...)
- Database file was missing/deleted
- Could not deploy to other machines

### Solution
- ? Created `DatabaseHelper.cs` for centralized database management
- ? Automatic database creation on first run
- ? Database stored in user's AppData folder (works on any machine)
- ? All forms updated to use the new connection system
- ? Added error handling and user-friendly messages

## ?? How to Deploy

### Quick Deployment (Recommended)
1. Build the project in **Release** mode (Ctrl+Shift+B)
2. Go to `IncomeandExpensesTracker\bin\Release\`
3. Copy ALL files from this folder
4. Paste them anywhere on the target computer
5. Run `IncomeandExpensesTracker.exe`

### Automated Build (Using PowerShell Script)
```powershell
.\Build-And-Package.ps1
```
This will:
- Build the project
- Create a Publish folder
- Optionally create a ZIP file

## ?? What Happens on First Run

1. Application starts
2. Checks for database in `%AppData%\IncomeandExpensesTracker\`
3. If not found, creates:
   - New `expense.mdf` database file
   - All required tables (users, categories, income, expenses)
   - Default admin user (username: admin, password: admin)
   - Sample categories

## ?? Default Login
```
Username: admin
Password: admin
```

## ?? File Structure After Deployment

```
YourAppFolder/
??? IncomeandExpensesTracker.exe (Main application)
??? IncomeandExpensesTracker.exe.config
??? System.Data.SqlClient.dll (and other dependencies)
??? (other DLL files)

User's AppData/
??? %AppData%\Roaming\IncomeandExpensesTracker\
    ??? expense.mdf (Database file)
    ??? expense_log.ldf (Database log)
```

## ?? Requirements for Users

### Minimum Requirements
- Windows 7 or later
- .NET Framework 4.7.2 or later
- SQL Server LocalDB

### Installing SQL Server LocalDB
If users don't have LocalDB installed:
1. Download from: https://go.microsoft.com/fwlink/?linkid=866658
2. Run the installer
3. Restart the application

## ?? Testing the Deployment

1. **Test on your machine first:**
   ```
   cd IncomeandExpensesTracker\bin\Release
   IncomeandExpensesTracker.exe
   ```

2. **Test the database creation:**
   - Close the app
   - Delete: `%AppData%\IncomeandExpensesTracker\expense.mdf`
   - Run the app again
   - Database should be recreated automatically

3. **Test the login:**
   - Use username: `admin`, password: `admin`
   - Should login successfully

4. **Test creating a new user:**
   - Click "SIGN UP"
   - Create a new account
   - Login with the new account

## ?? Next Steps for Distribution

### Option 1: Simple ZIP File
```powershell
# Compress the Release folder
Compress-Archive -Path "IncomeandExpensesTracker\bin\Release\*" -DestinationPath "IncomeAndExpensesTracker.zip"
```

### Option 2: Create an Installer
Use one of these tools:
- **Inno Setup** (Free): https://jrsoftware.org/isinfo.php
- **WiX Toolset** (Free): https://wixtoolset.org/
- **Advanced Installer** (Paid): https://www.advancedinstaller.com/

### Option 3: ClickOnce Publishing
In Visual Studio:
1. Right-click project ? **Publish**
2. Choose **Folder**
3. Click **Publish**

## ?? Common Issues

### "Cannot connect to database"
- **Solution**: Install SQL Server LocalDB

### "Access denied to AppData folder"
- **Solution**: Run application as Administrator (first time only)

### "Tables not found"
- **Solution**: Delete database file and restart app to recreate

## ?? Features Overview

- ? User registration and authentication
- ? Category management (Income/Expenses)
- ? Income tracking with dates
- ? Expense tracking with dates  
- ? Dashboard with statistics:
  - Today's totals
  - Yesterday's totals
  - This month's totals
  - This year's totals
  - All-time totals

## ?? Files Created

1. **DatabaseHelper.cs** - Core database management
2. **CreateDatabase.sql** - Manual database creation script (optional)
3. **DEPLOYMENT_GUIDE.md** - Detailed deployment guide
4. **Build-And-Package.ps1** - Automated build script
5. **QUICK_START.md** - This file

## ? You're Ready to Deploy!

Your application is now ready for deployment. Simply build in Release mode and distribute the files!

**Need help?** Check the DEPLOYMENT_GUIDE.md for more detailed information.
