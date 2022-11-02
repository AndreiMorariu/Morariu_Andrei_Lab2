using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Morariu_Andrei_Lab2.Models;

namespace Morariu_Andrei_Lab2.Data
{
    public class Morariu_Andrei_Lab2Context : DbContext
    {
        public Morariu_Andrei_Lab2Context (DbContextOptions<Morariu_Andrei_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Morariu_Andrei_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Morariu_Andrei_Lab2.Models.Publisher> Publisher { get; set; }

        public DbSet<Morariu_Andrei_Lab2.Models.Author> Author { get; set; }

        public DbSet<Morariu_Andrei_Lab2.Models.Category> Category { get; set; }
    }
}
