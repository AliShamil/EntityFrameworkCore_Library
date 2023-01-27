using EntityFrameworkCore_Library.Contexts;
using EntityFrameworkCore_Library.Enums;
using EntityFrameworkCore_Library.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkCore_Library;


class Program
{
    static void Main()
    {
        var context = new LibraryDBContext();

        //context.BookTypes.AddRange
        //    (
        //    new BookType()
        //    {
        //        Name = "Bases of data",
        //    },
        //    new BookType()
        //    {
        //        Name = "Programming"
        //    },
        //    new BookType()
        //    {
        //        Name = "Networks"
        //    }
        //    );

        //context.SaveChanges();

        //foreach (var item in context.BookTypes)
        //{
        //    Console.WriteLine(item.Name);
        //}



      //  context.Books.AddRange
      //      (
      //      new Book()
      //      {
      //          Name = "SQL",
      //          BookTypeId = Random.Shared.Next(1, 3),
      //          PageCount = Random.Shared.Next(500),
      //      },
      //      new Book()
      //      {
      //          Name = "Mathcad 2000",
      //          BookTypeId = Random.Shared.Next(1, 3),
      //          PageCount = Random.Shared.Next(500),
      //          Status = DataStatus.Updated
      //      },
      //       new Book()
      //       {
      //           Name = "Windows 2000 registry",
      //           BookTypeId = Random.Shared.Next(1, 3),
      //           PageCount = Random.Shared.Next(500),
      //       },
      //      new Book()
      //      {
      //          Name = "Course of mathematical analysis",
      //          BookTypeId = Random.Shared.Next(1, 3),
      //          PageCount = Random.Shared.Next(1000),
      //          Status = DataStatus.Deleted
      //      }
      //      ); ;


      //context.SaveChanges();

        var list = context.Books.Select(b => new
        {
            b.Id,
            b.Name,
            b.PageCount,
            b.BookTypeId,
            b.Status
        });


        foreach (var book in list)
        {
            Console.WriteLine(@$"Id:{book.Id}
        Name: {book.Name}
        PageCount: {book.PageCount}
        BookTypeId: {book.BookTypeId}
        Status: {book.Status}
        ");
        }
    }
}