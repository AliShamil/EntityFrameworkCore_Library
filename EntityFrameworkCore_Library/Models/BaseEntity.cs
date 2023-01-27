﻿using EntityFrameworkCore_Library.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCore_Library.Models;

public abstract class BaseEntity
{
    public int Id { get; set; }
    public DataStatus Status { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime? ModifiedDate { get; set; }

    public BaseEntity()
    {
        CreatedDate = DateTime.Now;
        Status = DataStatus.Inserted;
    }
}
