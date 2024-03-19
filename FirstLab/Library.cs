using FirstLab;
using System;
using System.Collections.Generic;

public class Library
{
    private List<Book> books;

    public Library()
    {
        books = new List<Book>();
    }

    public void AddBook(Book book)
    {
        books.Add(book);
    }

    public void RemoveBook(Book book)
    {
        books.Remove(book);
    }

    public List<Book> SearchByAuthor(string author)
    {
        return books.FindAll(book => book.Author.Equals(author, StringComparison.OrdinalIgnoreCase));
    }

    public List<Book> SearchByTitle(string title)
    {
        return books.FindAll(book => book.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
    }

    public List<Book> GetAllBooks()
    {
        return books;
    }
}
