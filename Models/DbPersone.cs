
using Microsoft.EntityFrameworkCore;

namespace bronzetti.christian._5h.PrimoEF.Models
{
    public class DbPersone : DbContext
    {
        public DbSet<Persona> Persone { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder opzioni)
        {
            opzioni.UseSqlite("Data Source=dbPersone.db");
        }
    }
}