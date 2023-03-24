using DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class Lab3DbContext : DbContext
    {
        public Lab3DbContext()
        {
        }
        public Lab3DbContext(DbContextOptions<Lab3DbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<University>()
                .HasKey(u => u.Code);

            modelBuilder.Entity<Faculty>()
                .HasOne(f => f.University)
                .WithMany(u => u.Faculties)
                .HasForeignKey(f => f.UniversityCode);


        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=KTOMY\\SQLEXPRESS;Initial Catalog=II-Laboratory;Integrated Security=True;Encrypt=False");
        }

        public DbSet<University> Universities { get; set; }
        public DbSet<Faculty> Faculties { get; set; }
    }
}