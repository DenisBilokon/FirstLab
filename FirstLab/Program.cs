using FirstLab;
using System;

class Program
{
    static void Main(string[] args)
    {
        Library library = new Library();
        
        #region Books
        Book book1 = new Book("Kobzar", "Taras Shevchenko", 1840, "978-617-7552-85-5");
        library.AddBook(book1);
        
        Book book2 = new Book("Les Misérables", "Victor Hugo", 1862, "976-217-6552-85-52");
        library.AddBook(book2);

        Book book3 = new Book("The Mirror of the Unknown", "Victor Hugo", 1862, "26-57-111-25-12");
        library.AddBook(book3);
        #endregion

        string authorToSearch1 = "Taras Shevchenko";

        var booksByAuthor = library.SearchByAuthor(authorToSearch1);
        Console.WriteLine($"Books by author '{authorToSearch1}':");
        foreach (var book in booksByAuthor)
        {
            Console.WriteLine($"{book.Title} ({book.Year})");
        }

        Console.WriteLine();
        Console.WriteLine("All books in the library:");
        var allBooks = library.GetAllBooks();
        foreach (var book in allBooks)
        {
            Console.WriteLine($"{book.Title} - {book.Author}");
        }
        Console.ReadLine();
    }
}
