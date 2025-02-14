LibraryApp

LibraryApp is a Windows Forms application developed in C# using .NET 8 in Visual Studio. It offers essential functionalities for managing a library, including the administration of books, users, and loans.
Table of Contents

    Features
    Prerequisites
    Installation
    Usage
    Security
    License
    Acknowledgments

Features

    Book Management:
        Add new books to the library.
        Delete existing books from the library.
        Display a list of available books.
        Search for a book by title, author, or ISBN code.
        Sort books by title, author, genre, or publication date.

    User Management:
        Add, delete, and update user information.
        Change password and username.

    Loan Management:
        Manage book loans and returns.
        Generate reports on borrowed and available books.

    Personalized Recommendations:
        Upon each login, users receive randomly selected book recommendations.

    Authentication System:
        Users must log in with a username and password to access the application's functionalities.
        Passwords are secured using SHA-256 encryption.

Prerequisites

    Operating System: Windows 7 or Windows 10.
    .NET 8 or later
    Development Environment: Visual Studio.

Installation

    Clone the Repository:

    git clone https://github.com/AkoForU/LibraryApp.git
    cd LibraryApp

    Open the Solution:

    Open the Biblioteca.sln file in Visual Studio.

    Database Configuration:
        Set up a local database to store information about books, users, and loans.
        Update the connection string in the application's configuration file to match your SQL Server instance.

    Build and Run:

    Press F5 in Visual Studio to build and run the application.

Usage

    Authentication:
        Enter your username and password to log in.

    Menu Navigation:
        Use the main menu to access the application's functionalities, such as managing books, users, and loans.

    Search and Sort:
        Use the search bar to find books by title, author, or ISBN code.
        Sort the book list by available criteria to quickly find the desired information.

Security

To ensure the security of user data, the application uses SHA-256 encryption for password storage. This guarantees that passwords are protected against unauthorized access.
Contributions


License

This project is licensed under the MIT License.
