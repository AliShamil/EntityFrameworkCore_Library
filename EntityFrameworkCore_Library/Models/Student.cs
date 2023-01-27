using EntityFrameworkCore_Library.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCore_Library.Models;

public class Student :BaseEntity
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public short SchoolNumber { get; set; }
    public Gender Gender { get; set; }
    public DateTime BirthDate { get; set; }
    public string PhoneNumber { get; set; }

    // Navigation Property
    public List<Book> Books { get; set; }
}
