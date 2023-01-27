using EntityFrameworkCore_Library.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCore_Library.Contexts
{
    public class LibraryDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
   .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
   .AddJsonFile("appsettings.json")
   .Build();

            var conStr = configuration.GetConnectionString("ConStrLib");

            optionsBuilder.UseSqlServer(conStr);

            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<BookType> BookTypes { get; set; }
    }
}
