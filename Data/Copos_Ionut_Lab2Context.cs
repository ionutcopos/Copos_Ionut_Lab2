using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Copos_Ionut_Lab2.Data
{
    public class Copos_Ionut_Lab2Context : DbContext
    {
        public Copos_Ionut_Lab2Context (DbContextOptions<Copos_Ionut_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Book> Book { get; set; } = default!;
        public DbSet<Publisher> Publisher { get; set; } = default!;
    }
}
