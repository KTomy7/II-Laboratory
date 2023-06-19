﻿// <auto-generated />
using Exam;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Exam.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Exam.Models.Project", b =>
                {
                    b.Property<int>("ProjectID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProjectID"));

                    b.Property<int>("Buget")
                        .HasColumnType("int");

                    b.Property<string>("ProjectName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProjectID");

                    b.ToTable("Projects");

                    b.HasData(
                        new
                        {
                            ProjectID = 1,
                            Buget = 100,
                            ProjectName = "Project1"
                        },
                        new
                        {
                            ProjectID = 2,
                            Buget = 200,
                            ProjectName = "Project2"
                        },
                        new
                        {
                            ProjectID = 3,
                            Buget = 300,
                            ProjectName = "Project3"
                        });
                });

            modelBuilder.Entity("Exam.Models.Team", b =>
                {
                    b.Property<int>("TeamID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TeamID"));

                    b.Property<int>("ProjectID")
                        .HasColumnType("int");

                    b.HasKey("TeamID");

                    b.HasIndex("ProjectID");

                    b.ToTable("Teams");

                    b.HasData(
                        new
                        {
                            TeamID = 1,
                            ProjectID = 1
                        },
                        new
                        {
                            TeamID = 2,
                            ProjectID = 1
                        },
                        new
                        {
                            TeamID = 3,
                            ProjectID = 2
                        },
                        new
                        {
                            TeamID = 4,
                            ProjectID = 3
                        });
                });

            modelBuilder.Entity("Exam.Models.Team", b =>
                {
                    b.HasOne("Exam.Models.Project", "Project")
                        .WithMany()
                        .HasForeignKey("ProjectID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Project");
                });
#pragma warning restore 612, 618
        }
    }
}