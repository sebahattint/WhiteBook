﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace Whitebook.DataAccess.Context
{
    public class WhiteBookContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server = (localdb)\mssqllocaldb; initial catalog =Northwind; integrated security = true");
        }
    }
}