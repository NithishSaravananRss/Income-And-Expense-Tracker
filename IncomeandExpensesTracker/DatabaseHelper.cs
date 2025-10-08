using System;
using System.IO;
using System.Data.SqlClient;

namespace IncomeandExpensesTracker
{
    /// <summary>
    /// Centralized database connection helper for deployment
    /// </summary>
    public static class DatabaseHelper
    {
        private static string connectionString;

        /// <summary>
        /// Gets the connection string with relative path to database
        /// </summary>
        public static string GetConnectionString()
        {
            if (string.IsNullOrEmpty(connectionString))
            {
                connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\expense.mdf;Integrated Security=True;Connect Timeout=30";
            }
            return connectionString;
        }

        /// <summary>
        /// Ensures database exists and is properly set up in the user's AppData folder
        /// </summary>
        public static void EnsureDatabaseExists()
        {
            try
            {
                string dataDirectory = AppDomain.CurrentDomain.GetData("DataDirectory") as string;
                
                if (string.IsNullOrEmpty(dataDirectory))
                {
                    // Set data directory to user's AppData folder
                    dataDirectory = Path.Combine(
                        Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                        "IncomeandExpensesTracker"
                    );
                    AppDomain.CurrentDomain.SetData("DataDirectory", dataDirectory);
                }

                // Create directory if it doesn't exist
                if (!Directory.Exists(dataDirectory))
                {
                    Directory.CreateDirectory(dataDirectory);
                }

                string dbPath = Path.Combine(dataDirectory, "expense.mdf");
                
                // If database doesn't exist, create it
                if (!File.Exists(dbPath))
                {
                    // Try to copy from application directory first
                    string sourceDbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "expense.mdf");
                    
                    if (File.Exists(sourceDbPath))
                    {
                        File.Copy(sourceDbPath, dbPath);
                        
                        // Also copy the log file if it exists
                        string sourceLdfPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "expense_log.ldf");
                        string destLdfPath = Path.Combine(dataDirectory, "expense_log.ldf");
                        if (File.Exists(sourceLdfPath))
                        {
                            File.Copy(sourceLdfPath, destLdfPath);
                        }
                    }
                    else
                    {
                        // Create a new database from scratch
                        CreateNewDatabase(dbPath);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to initialize database: {ex.Message}", ex);
            }
        }

        /// <summary>
        /// Creates a new database file with the required schema
        /// </summary>
        private static void CreateNewDatabase(string dbPath)
        {
            string connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;Integrated Security=True;Connect Timeout=30";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Create the database
                string createDbCommand = $@"
                    CREATE DATABASE [ExpenseDB] 
                    ON PRIMARY (
                        NAME = ExpenseDB_Data,
                        FILENAME = '{dbPath}'
                    )
                    LOG ON (
                        NAME = ExpenseDB_Log,
                        FILENAME = '{dbPath.Replace(".mdf", "_log.ldf")}'
                    )";

                using (SqlCommand command = new SqlCommand(createDbCommand, connection))
                {
                    command.ExecuteNonQuery();
                }
            }

            // Now create the tables
            string dbConnectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={dbPath};Integrated Security=True;Connect Timeout=30";
            
            using (SqlConnection connection = new SqlConnection(dbConnectionString))
            {
                connection.Open();

                // Create tables
                string createTablesScript = @"
                    -- Create users table
                    CREATE TABLE users (
                        id INT PRIMARY KEY IDENTITY(1,1),
                        username NVARCHAR(100) NOT NULL UNIQUE,
                        password NVARCHAR(100) NOT NULL,
                        date_create DATE NOT NULL
                    );

                    -- Create categories table
                    CREATE TABLE categories (
                        id INT PRIMARY KEY IDENTITY(1,1),
                        category NVARCHAR(100) NOT NULL,
                        type NVARCHAR(50) NOT NULL,
                        status NVARCHAR(50) NOT NULL,
                        date_insert DATE NOT NULL
                    );

                    -- Create income table
                    CREATE TABLE income (
                        id INT PRIMARY KEY IDENTITY(1,1),
                        category NVARCHAR(100) NOT NULL,
                        item NVARCHAR(200) NOT NULL,
                        income DECIMAL(18,2) NOT NULL,
                        description NVARCHAR(MAX),
                        date_income DATE NOT NULL,
                        date_insert DATE NOT NULL
                    );

                    -- Create expenses table
                    CREATE TABLE expenses (
                        id INT PRIMARY KEY IDENTITY(1,1),
                        category NVARCHAR(100) NOT NULL,
                        item NVARCHAR(200) NOT NULL,
                        cost DECIMAL(18,2) NOT NULL,
                        description NVARCHAR(MAX),
                        date_expense DATE NOT NULL,
                        date_insert DATE NOT NULL
                    );

                    -- Insert default admin user
                    INSERT INTO users (username, password, date_create) 
                    VALUES ('admin', 'admin', GETDATE());

                    -- Insert sample categories
                    INSERT INTO categories (category, type, status, date_insert) VALUES 
                    ('Salary', 'Income', 'Active', GETDATE()),
                    ('Business', 'Income', 'Active', GETDATE()),
                    ('Investment', 'Income', 'Active', GETDATE()),
                    ('Food', 'Expenses', 'Active', GETDATE()),
                    ('Transport', 'Expenses', 'Active', GETDATE()),
                    ('Utilities', 'Expenses', 'Active', GETDATE()),
                    ('Entertainment', 'Expenses', 'Active', GETDATE());
                ";

                using (SqlCommand command = new SqlCommand(createTablesScript, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
