-- Income and Expenses Tracker Database Schema
-- Run this script in SQL Server Management Studio or Visual Studio to create the database

-- Create the database if it doesn't exist
IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = 'ExpenseDB')
BEGIN
    CREATE DATABASE ExpenseDB
END
GO

USE ExpenseDB
GO

-- Create users table
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'users')
BEGIN
    CREATE TABLE users (
        id INT PRIMARY KEY IDENTITY(1,1),
        username NVARCHAR(100) NOT NULL UNIQUE,
        password NVARCHAR(100) NOT NULL,
        date_create DATE NOT NULL
    )
END
GO

-- Create categories table
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'categories')
BEGIN
    CREATE TABLE categories (
        id INT PRIMARY KEY IDENTITY(1,1),
        category NVARCHAR(100) NOT NULL,
        type NVARCHAR(50) NOT NULL, -- Income or Expenses
        status NVARCHAR(50) NOT NULL, -- Active or Inactive
        date_insert DATE NOT NULL
    )
END
GO

-- Create income table
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'income')
BEGIN
    CREATE TABLE income (
        id INT PRIMARY KEY IDENTITY(1,1),
        category NVARCHAR(100) NOT NULL,
        item NVARCHAR(200) NOT NULL,
        income DECIMAL(18,2) NOT NULL,
        description NVARCHAR(MAX),
        date_income DATE NOT NULL,
        date_insert DATE NOT NULL
    )
END
GO

-- Create expenses table
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'expenses')
BEGIN
    CREATE TABLE expenses (
        id INT PRIMARY KEY IDENTITY(1,1),
        category NVARCHAR(100) NOT NULL,
        item NVARCHAR(200) NOT NULL,
        cost DECIMAL(18,2) NOT NULL,
        description NVARCHAR(MAX),
        date_expense DATE NOT NULL,
        date_insert DATE NOT NULL
    )
END
GO

-- Insert some sample data for testing (optional)
-- Insert a default user (username: admin, password: admin)
IF NOT EXISTS (SELECT * FROM users WHERE username = 'admin')
BEGIN
    INSERT INTO users (username, password, date_create) 
    VALUES ('admin', 'admin', GETDATE())
END
GO

-- Insert some sample categories
IF NOT EXISTS (SELECT * FROM categories WHERE category = 'Salary')
BEGIN
    INSERT INTO categories (category, type, status, date_insert) VALUES 
    ('Salary', 'Income', 'Active', GETDATE()),
    ('Business', 'Income', 'Active', GETDATE()),
    ('Investment', 'Income', 'Active', GETDATE()),
    ('Food', 'Expenses', 'Active', GETDATE()),
    ('Transport', 'Expenses', 'Active', GETDATE()),
    ('Utilities', 'Expenses', 'Active', GETDATE()),
    ('Entertainment', 'Expenses', 'Active', GETDATE())
END
GO

PRINT 'D