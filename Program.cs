using LibraryManagementSystem.BusinessLogic;
using System;

namespace LibraryManagementSystem2
{
    public class Program
    {
        static void Main(string[] args)
        {
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
                        AddBook();
                        break;
                    case "2":
                        ViewBooks();
                        break;
                    case "3":
                        UpdateBook();
                        break;
                    case "4":
                        DeleteBook();
                        break;
                    case "5":
                        Console.WriteLine("Exiting Library System...");
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid input.");
                        break;
                }
            }
        }

        static void AddBook()
        {
            Console.Write("Book No: ");
            int num = int.Parse(Console.ReadLine());
            Console.Write("Title: ");
            string title = Console.ReadLine();
            Console.Write("Author: ");
            string author = Console.ReadLine();
            Console.Write("Year: ");
            int year = int.Parse(Console.ReadLine());

            var book = LibraryProcess.CreateBook(num, title, author, year);
            LibraryProcess.PerformAction(LibraryAction.Add, book);
            Console.WriteLine("Book added!");
        }

        static void ViewBooks()
        {
            var books = LibraryProcess.GetBooks();
            Console.WriteLine("\n--- Book List ---");
            foreach (var b in books)
                Console.WriteLine(b);
        }

        static void UpdateBook()
        {
            Console.Write("Enter Book No to update: ");
            int num = int.Parse(Console.ReadLine());
            Console.Write("New Title: ");
            string title = Console.ReadLine();
            Console.Write("New Author: ");
            string author = Console.ReadLine();
            Console.Write("New Year: ");
            int year = int.Parse(Console.ReadLine());

            bool success = LibraryProcess.UpdateBook(num, title, author, year);
            Console.WriteLine(success ? "Updated!" : "Book not found.");
        }

        static void DeleteBook()
        {
            Console.Write("Enter Book No to delete: ");
            int num = int.Parse(Console.ReadLine());

            var book = LibraryProcess.CreateBook(num, "", "", 0);
            LibraryProcess.PerformAction(LibraryAction.Delete, book);
            Console.WriteLine("Book deleted if exists.");
        }
    }
}
