﻿using ExpensesAPI.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ExpensesAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("name=ExpenesesDb")
        {

        }
        public DbSet<Entry> Entries { get; set; }
    }
}