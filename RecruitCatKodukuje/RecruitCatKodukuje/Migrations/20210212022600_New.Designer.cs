﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RecruitCatKodukuje.Data;

namespace RecruitCatKodukuje.Migrations
{
    [DbContext(typeof(RecruitCatKodukujeContext))]
    [Migration("20210212022600_New")]
    partial class New
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RecruitCatKodukuje.Models.Candidate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IndustryId")
                        .HasColumnType("int");

                    b.Property<int>("JobTitleId")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MathHackId")
                        .HasColumnType("int");

                    b.Property<DateTime>("OptionalStartDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("TargetSalary")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("WorkExp")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IndustryId");

                    b.HasIndex("JobTitleId");

                    b.HasIndex("MathHackId");

                    b.ToTable("Candidate");
                });

            modelBuilder.Entity("RecruitCatKodukuje.Models.Industry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Industry");
                });

            modelBuilder.Entity("RecruitCatKodukuje.Models.JobTitle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("MaxSalary")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("MinSalary")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("JobTitle");
                });

            modelBuilder.Entity("RecruitCatKodukuje.Models.MathHack", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ContactNum")
                        .HasColumnType("int");

                    b.Property<int>("IndustryId")
                        .HasColumnType("int");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("MaxSalary")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("MinSalary")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumOfEmp")
                        .HasColumnType("int");

                    b.Property<DateTime>("OptionalStartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("IndustryId");

                    b.ToTable("MathHack");
                });

            modelBuilder.Entity("RecruitCatKodukuje.Models.Candidate", b =>
                {
                    b.HasOne("RecruitCatKodukuje.Models.Industry", "Industry")
                        .WithMany("Candidates")
                        .HasForeignKey("IndustryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RecruitCatKodukuje.Models.JobTitle", "JobTitle")
                        .WithMany("Candidates")
                        .HasForeignKey("JobTitleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RecruitCatKodukuje.Models.MathHack", "MathHack")
                        .WithMany("Candidates")
                        .HasForeignKey("MathHackId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RecruitCatKodukuje.Models.MathHack", b =>
                {
                    b.HasOne("RecruitCatKodukuje.Models.Industry", "Industry")
                        .WithMany("MathHacks")
                        .HasForeignKey("IndustryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
