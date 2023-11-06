using Koutye.Models;
using Microsoft.EntityFrameworkCore;

namespace Koutye.Data
{
    public class KoutyeContext:DbContext
    {
        public DbSet<Utilisateur> Utilisateurs { get; set; }
        public DbSet<TypeUtilisateur> typeUtilisateurs { get; set; }

        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-OORU9G9\MSSQLSERVER01;Initial Catalog=KoutyeDB;Integrated Security=True;TrustServerCertificate=True");
        }
        
    }
}
