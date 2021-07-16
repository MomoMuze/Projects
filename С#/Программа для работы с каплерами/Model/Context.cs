using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;//Подключение к SQLite

namespace infSis.Model
{
    public class Context : DbContext
    {
        public DbSet<Dann> Danns { get; set; }
        public DbSet<Plata> Platas { get; set; }
        public DbSet<Type> Types { get; set; }

        //Подключение к SQLite
        public Context()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=InfSis.db");
        }
    }

}
