// See https://aka.ms/new-console-template for more information
using Microsoft.EntityFrameworkCore;
using PublisherData;
using PublisherDomain;

using (PubContext context = new PubContext())//Es como un truco, alta hardcodeada
{
    context.Database.EnsureCreated();
}

//GetAuthors();
//AddAuthors();
//GetAuthors();

GetAuthorsWithBooks();

void AddAuthorithBook()
{
    var author = new Author { FirstName = "Antonella", LastName = "Bologna" };
    author.Books.Add(new Book { Title = "Programming Entity", PublishDate = new DateTime(2009, 1, 1) });
    author.Books.Add(new Book { Title = "Programming Entity 2nd Editionm", PublishDate = new DateTime(2020, 8, 1) });
    using var context = new PubContext();
    context.Authors.Add(author);
    context.SaveChanges();
}

void GetAuthorsWithBooks()
{
    using var context = new PubContext();
    var authors = context.Authors.Include(a => a.Books).ToList();
    foreach (var author in authors)
    {
        Console.WriteLine(author.FirstName + " " + author.LastName);
        foreach (var book in author.Books)
        {
            Console.WriteLine("*" + book.Title);
        }
    }
}

void AddAuthors()
{
    var author = new Author { FirstName = "NIcolas", LastName = "Bologna" };
    using var context = new PubContext();
    context.Authors.Add(author);
    context.SaveChanges();
}

void GetAuthors()
{
    using var context = new PubContext();
    var authors = context.Authors.ToList();
    foreach (var author in authors)
    {
        Console.WriteLine(author.FirstName + "" + author.LastName);
    }
}