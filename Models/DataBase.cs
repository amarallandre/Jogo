using Microsoft.EntityFrameworkCore;
using System;

namespace Jogo.Models
{
    public class DataBase : DbContext
    {
        public DbSet<Personagem> Personagens { get; set; }
        public DbSet<Inimigo> Inimigos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Configuração para SQLite
            optionsBuilder.UseSqlite("Data Source=app.db");
        }

    }
}