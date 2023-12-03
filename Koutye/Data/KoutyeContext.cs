using Koutye.Models;
using Microsoft.EntityFrameworkCore;


namespace Koutye.Data
{
    public class KoutyeContext:DbContext
    {
        public DbSet<Utilisateur> utilisateur { get; set; }
        public DbSet<TypeUtilisateur> typeUtilisateur { get; set; }

        public DbSet<Adresse> adresse { get; set; }

        public DbSet<Appartement> appartement{ get; set; }
        public DbSet<Ferme> ferme { get; set; }
        public DbSet<ImageAppartement> imageAppartement { get; set; }
        public DbSet<VideoAppartement> videoAppartement { get;set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-OORU9G9\MSSQLSERVER01;Initial Catalog=KoutyeDB;Integrated Security=True;TrustServerCertificate=True");
        }
        /*
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
        */
    }
}
