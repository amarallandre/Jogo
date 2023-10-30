using Microsoft.EntityFrameworkCore;

namespace Jogo.Models
{
    public class DataBase : DbContext
    {
        public DbSet<Personagem> Personagens { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Configuração para SQLite
            optionsBuilder.UseSqlite("Data Source=app.db");
        }
    }
}


