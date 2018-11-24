﻿// <auto-generated />
using System;
using CatchUp.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CatchUp.Migrations
{
    [DbContext(typeof(LessonsContext))]
    partial class LessonsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CatchUp.Models.Lessons.Lesson", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("OrderId");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.ToTable("Lessons");
                });

            modelBuilder.Entity("CatchUp.Models.Lessons.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date");

                    b.Property<int>("OfferId");

                    b.Property<int>("RoleId");

                    b.Property<int>("StudentId");

                    b.Property<int>("TeacherId");

                    b.HasKey("Id");

                    b.HasIndex("OfferId");

                    b.HasIndex("RoleId");

                    b.HasIndex("StudentId");

                    b.HasIndex("TeacherId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("CatchUp.Models.Lessons.Rating", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("LessonId");

                    b.Property<short>("Rate");

                    b.Property<int>("RoleId");

                    b.Property<int>("StudentId");

                    b.Property<int>("TeacherId");

                    b.HasKey("Id");

                    b.HasIndex("LessonId");

                    b.HasIndex("RoleId");

                    b.HasIndex("StudentId");

                    b.HasIndex("TeacherId");

                    b.ToTable("Rating");
                });

            modelBuilder.Entity("CatchUp.Models.Offers.Level", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("LevelName");

                    b.HasKey("Id");

                    b.ToTable("Level");
                });

            modelBuilder.Entity("CatchUp.Models.Offers.Offer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("HomeVisits");

                    b.Property<int?>("TeacherId");

                    b.Property<float?>("VisitRange");

                    b.HasKey("Id");

                    b.HasIndex("TeacherId");

                    b.ToTable("Offer");
                });

            modelBuilder.Entity("CatchUp.Models.Offers.Subject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("LessonMinutes");

                    b.Property<int>("LevelId");

                    b.Property<int?>("OfferId");

                    b.Property<decimal>("Price");

                    b.Property<int>("SubjectTypeId");

                    b.HasKey("Id");

                    b.HasIndex("LevelId");

                    b.HasIndex("OfferId");

                    b.HasIndex("SubjectTypeId");

                    b.ToTable("Subject");
                });

            modelBuilder.Entity("CatchUp.Models.Offers.SubjectType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("SubjectName");

                    b.HasKey("Id");

                    b.ToTable("SubjectType");
                });

            modelBuilder.Entity("CatchUp.Models.Roles.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City");

                    b.Property<string>("Flat");

                    b.Property<double>("Latitude");

                    b.Property<double>("Longitude");

                    b.Property<string>("Number");

                    b.Property<string>("PostalCode");

                    b.Property<string>("Street");

                    b.HasKey("Id");

                    b.ToTable("Address");
                });

            modelBuilder.Entity("CatchUp.Models.Roles.Graphic", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Begining");

                    b.Property<int>("Day");

                    b.Property<string>("Ending");

                    b.Property<int>("TeacherId");

                    b.HasKey("Id");

                    b.HasIndex("TeacherId");

                    b.ToTable("Graphic");
                });

            modelBuilder.Entity("CatchUp.Models.Roles.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("RoleType");

                    b.HasKey("Id");

                    b.ToTable("Role");
                });

            modelBuilder.Entity("CatchUp.Models.Roles.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AddressId");

                    b.Property<string>("Name");

                    b.Property<string>("Surname");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("CatchUp.Models.Roles.Teacher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AddressId");

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<string>("Surname");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.ToTable("Teacher");
                });

            modelBuilder.Entity("CatchUp.Models.Lessons.Lesson", b =>
                {
                    b.HasOne("CatchUp.Models.Lessons.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CatchUp.Models.Lessons.Order", b =>
                {
                    b.HasOne("CatchUp.Models.Offers.Offer", "Offer")
                        .WithMany()
                        .HasForeignKey("OfferId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CatchUp.Models.Roles.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CatchUp.Models.Roles.Student", "Student")
                        .WithMany("Orders")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CatchUp.Models.Roles.Teacher", "Teacher")
                        .WithMany("Orders")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CatchUp.Models.Lessons.Rating", b =>
                {
                    b.HasOne("CatchUp.Models.Lessons.Lesson", "Lesson")
                        .WithMany()
                        .HasForeignKey("LessonId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CatchUp.Models.Roles.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CatchUp.Models.Roles.Student", "Student")
                        .WithMany("Ratings")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CatchUp.Models.Roles.Teacher", "Teacher")
                        .WithMany("Ratings")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CatchUp.Models.Offers.Offer", b =>
                {
                    b.HasOne("CatchUp.Models.Roles.Teacher")
                        .WithMany("Offers")
                        .HasForeignKey("TeacherId");
                });

            modelBuilder.Entity("CatchUp.Models.Offers.Subject", b =>
                {
                    b.HasOne("CatchUp.Models.Offers.Level", "Level")
                        .WithMany()
                        .HasForeignKey("LevelId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CatchUp.Models.Offers.Offer")
                        .WithMany("Subjects")
                        .HasForeignKey("OfferId");

                    b.HasOne("CatchUp.Models.Offers.SubjectType", "SubjectType")
                        .WithMany()
                        .HasForeignKey("SubjectTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CatchUp.Models.Roles.Graphic", b =>
                {
                    b.HasOne("CatchUp.Models.Roles.Teacher", "Teacher")
                        .WithMany("Graphic")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CatchUp.Models.Roles.Student", b =>
                {
                    b.HasOne("CatchUp.Models.Roles.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CatchUp.Models.Roles.Teacher", b =>
                {
                    b.HasOne("CatchUp.Models.Roles.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}