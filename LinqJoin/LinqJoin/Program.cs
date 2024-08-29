using LinqJoin;
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // List of authors representing the Authors table with sample data
        List<Author> authors = new List<Author>
        {
            new Author { AuthorId = 1, Name = "George Orwell" },
            new Author { AuthorId = 2, Name = "J.K. Rowling" },
            new Author { AuthorId = 3, Name = "J.R.R. Tolkien" }
        };

        // List of books representing the Books table with sample data
        List<Book> books = new List<Book>
        {
            new Book { BookId = 1, Title = "1984", AuthorId = 1 },
            new Book { BookId = 2, Title = "Harry Potter", AuthorId = 2 },
            new Book { BookId = 3, Title = "The Hobbit", AuthorId = 3 },
            new Book { BookId = 4, Title = "Animal Farm", AuthorId = 1 }
        };

        // LINQ query to join books with authors based on AuthorId
        var query = from book in books
                    join author in authors on book.AuthorId equals author.AuthorId
                    select new { BookTitle = book.Title, AuthorName = author.Name };

        // Print the results to the console
        foreach (var item in query)
        {
            Console.WriteLine($"Book: {item.BookTitle}, Author: {item.AuthorName}");
        }
    }
}