﻿// See https://aka.ms/new-console-template for more information
using PublisherData;

//GetAuthors();

//void GetAuthors()
//{
//    using var context = new PubContext();
//    var authors = context.Authors.ToList();
//    foreach (var author in authors)
//    {
//        Console.WriteLine(author.FirstName + " " + author.LastName);
//    }
//}

PubContext _context = new PubContext();

QueryFilters();

void QueryFilters()
{
    var authors = _context.Authors.Where(s => s.FirstName == "Josie").ToList();
}