﻿// <auto-generated />
using System;
using ApiUsers.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Api_Academico.Migrations
{
    [DbContext(typeof(UsersContext))]
    [Migration("20220909161244_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Api_Academico.Models.AllocationLoad", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateAllocationLoad")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdCourse")
                        .HasColumnType("int");

                    b.Property<int>("IdGrade")
                        .HasColumnType("int");

                    b.Property<int>("IdUser")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdCourse");

                    b.HasIndex("IdGrade");

                    b.HasIndex("IdUser");

                    b.ToTable("AllocationLoads");
                });

            modelBuilder.Entity("Api_Academico.Models.Califications", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Calification1")
                        .HasColumnType("int");

                    b.Property<int>("Calification2")
                        .HasColumnType("int");

                    b.Property<int>("Calification3")
                        .HasColumnType("int");

                    b.Property<int>("CalificationFinal")
                        .HasColumnType("int");

                    b.Property<int>("IdAllocationLoad")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdAllocationLoad");

                    b.ToTable("Califications");
                });

            modelBuilder.Entity("Api_Academico.Models.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NameCourse")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("WeeklyHours")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("Api_Academico.Models.Follow_upCourse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateFollowUp")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdGrade")
                        .HasColumnType("int");

                    b.Property<int>("IdUser")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdGrade");

                    b.HasIndex("IdUser");

                    b.ToTable("Follow_up_courses");
                });

            modelBuilder.Entity("Api_Academico.Models.Grade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CodGrade")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Grades");
                });

            modelBuilder.Entity("Api_Academico.Models.Lounge", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameLounge")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Lounges");
                });

            modelBuilder.Entity("Api_Academico.Models.Roles", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NameRole")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Api_Academico.Models.Schedule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Friday")
                        .HasColumnType("int");

                    b.Property<int>("IdAllocationLoad")
                        .HasColumnType("int");

                    b.Property<string>("Monday")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Thursday")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tuesday")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Wednesday")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdAllocationLoad");

                    b.ToTable("Schedules");
                });

            modelBuilder.Entity("Api_Academico.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Doc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdRol")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RolesId")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("TypeDoc")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("RolesId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Api_Academico.Models.AllocationLoad", b =>
                {
                    b.HasOne("Api_Academico.Models.Course", "Course")
                        .WithMany()
                        .HasForeignKey("IdCourse")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Api_Academico.Models.Grade", "Grade")
                        .WithMany()
                        .HasForeignKey("IdGrade")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Api_Academico.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("IdUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Api_Academico.Models.Califications", b =>
                {
                    b.HasOne("Api_Academico.Models.AllocationLoad", "AllocationLoad")
                        .WithMany()
                        .HasForeignKey("IdAllocationLoad")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Api_Academico.Models.Follow_upCourse", b =>
                {
                    b.HasOne("Api_Academico.Models.Grade", "Grade")
                        .WithMany()
                        .HasForeignKey("IdGrade")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Api_Academico.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("IdUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Api_Academico.Models.Schedule", b =>
                {
                    b.HasOne("Api_Academico.Models.AllocationLoad", "AllocationLoad")
                        .WithMany()
                        .HasForeignKey("IdAllocationLoad")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Api_Academico.Models.User", b =>
                {
                    b.HasOne("Api_Academico.Models.Roles", "Roles")
                        .WithMany()
                        .HasForeignKey("RolesId");
                });
#pragma warning restore 612, 618
        }
    }
}
