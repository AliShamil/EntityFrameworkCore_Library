using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCore_Library.Models;

public class Book : BaseEntity
{
    public string Name { get; set; }
    public int PageCount { get; set; }

    // Foreign key
    public int BookTypeId { get; set; }
    public int? StudentId { get; set; }

    // Navigation Property
    public Student Student { get; set; }
    public List<Author> Authors { get; set; }
    public BookType BookType { get; set; }
}
