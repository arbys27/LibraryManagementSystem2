using System;
using LibraryManagementSystem;
using LibraryManagementSystem.BusinessLogic;

public class Program
{
    static void Main(string[] args)
    {

        LibraryService libraryService = new LibraryService();
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("\n********** Library Management System **********");
            Console.WriteLine("1. Add Book");
            Console.WriteLine("2. View Books");
            Console.WriteLine("3. Update Book");
            Console.WriteLine("4. Delete Book");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddBook(libraryService);
                    break;
                case "2":
                    ViewBooks(libraryService);
                    break;
                case "3":
                    UpdateBook(libraryService);
                    break;
                case "4":
                    DeleteBook(libraryService);
                    break;
                case "5":
                    Console.WriteLine("Exiting Library System...");
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid option! Please try again.");
                    break;
            }
        }
    }

    static void AddBook(LibraryService libraryService)
    {
        Console.Write("Enter Book Number: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Enter Title: ");
        string title = Console.ReadLine();
        Console.Write("Enter Author: ");
        string author = Console.ReadLine();
        Console.Write("Enter Year: ");
        int year = int.Parse(Console.ReadLine());

        libraryService.AddBook(number, title, author, year);
        Console.WriteLine("Book added successfully.");
    }

    static void ViewBooks(LibraryService libraryService)
    {
        var books = libraryService.GetBooks();

        Console.WriteLine("\n--- Book List ---");
        if (books.Count == 0)
        {
            Console.WriteLine("No books available.");
        }
        else
        {
            foreach (var book in books)
            {
                Console.WriteLine(book);
            }
        }
    }

    static void UpdateBook(LibraryService libraryService)
    {
        Console.Write("Enter Book Number to update: ");
        int number = int.Parse(Console.ReadLine());

        Console.Write("Enter new Title: ");
        string newTitle = Console.ReadLine();
        Console.Write("Enter new Author: ");
        string newAuthor = Console.ReadLine();
        Console.Write("Enter new Year: ");
        int newYear = int.Parse(Console.ReadLine());

        bool success = libraryService.UpdateBook(number, newTitle, newAuthor, newYear);
        if (success)
            Console.WriteLine("Book updated successfully.");
        else
            Console.WriteLine("Book not found.");
    }

    static void DeleteBook(LibraryService libraryService)
    {
        Console.Write("Enter Book Number to delete: ");
        int number = int.Parse(Console.ReadLine());

        bool success = libraryService.DeleteBook(number);
        if (success)
            Console.WriteLine("Book deleted successfully.");
        else
            Console.WriteLine("Book not found.");
    }
}

