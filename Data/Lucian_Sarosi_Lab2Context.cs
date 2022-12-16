using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Lucian_Sarosi_Lab2.Models;

namespace Lucian_Sarosi_Lab2.Data
{
    public class Lucian_Sarosi_Lab2Context : DbContext
    {
        public Lucian_Sarosi_Lab2Context (DbContextOptions<Lucian_Sarosi_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Lucian_Sarosi_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Lucian_Sarosi_Lab2.Models.Publisher> Publisher { get; set; }

        public DbSet<Lucian_Sarosi_Lab2.Models.Category> Category { get; set; }

        public DbSet<Lucian_Sarosi_Lab2.Models.Author> Author { get; set; }

        public DbSet<Lucian_Sarosi_Lab2.Models.Member> Member { get; set; }

        public DbSet<Lucian_Sarosi_Lab2.Models.Borrowing> Borrowing { get; set; }
    }
}
