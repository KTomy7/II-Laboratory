using Exam.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Exam
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        {   
        }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Project>().HasData(
                new Project { ProjectID = 1, ProjectName = "Project1", Buget = 100 },
                new Project { ProjectID = 2, ProjectName = "Project2", Buget = 200 },
                new Project { ProjectID = 3, ProjectName = "Project3", Buget = 300 }
            );
            modelBuilder.Entity<Team>().HasData(
                new Team { TeamID = 1, ProjectID = 1 },
                new Team { TeamID = 2, ProjectID = 1 },
                new Team { TeamID = 3, ProjectID = 2 },
                new Team { TeamID = 4, ProjectID = 3 }    
            );
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=KTOMY\\SQLEXPRESS;Initial Catalog=Company;Integrated Security=True;Encrypt=False");
        }

        public DbSet<Project> Projects { get; set; }
        public DbSet<Team> Teams { get; set; }
    }
}
