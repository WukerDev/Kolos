using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wiktor_Kozakowski
{
    internal class obsluga : DbContext
    {
        public DbSet<Towar> Towar { get; set; }
        public DbSet<StanMagazynowy> StanMagazynowy { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = baza.db");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
