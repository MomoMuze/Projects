using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;//Подключение к SQLite

namespace infSis.Model
{
    public class infSisContext : DbContext
    {
        public DbSet<Dann> Danns { get; set; }
        public DbSet<Tipe> Tipes { get; set; }
        public DbSet<Pozl> Pozls { get; set; }


        //Подключение к SQLite
        public infSisContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=InfSis.db");
        }
    }

}
