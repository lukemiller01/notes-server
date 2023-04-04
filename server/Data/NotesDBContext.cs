//Acts as a bridge between the data and entity framework

using System;
using Microsoft.EntityFrameworkCore;
using server.Models;

namespace server.Data
{
    public class NotesDBContext : DbContext
    {
        // Constructor gets options and passes it to the base class
        public NotesDBContext(DbContextOptions options) : base(options)
        { 
        }

        // Same name of table that's created as part of EntityFrameworkCore
        public DbSet<Note> Notes { get; set; }
    }
}

