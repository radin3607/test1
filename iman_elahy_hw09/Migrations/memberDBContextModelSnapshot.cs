﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using iman_elahy_hw09.data;

#nullable disable

namespace iman_elahy_hw09.Migrations
{
    [DbContext(typeof(memberDBContext))]
    partial class memberDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("iman_elahy_hw09.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Memberid")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("libraryId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("libraryId");

                    b.ToTable("books");
                });

            modelBuilder.Entity("iman_elahy_hw09.Models.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("citys");
                });

            modelBuilder.Entity("iman_elahy_hw09.Models.Library", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Addres")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("librarycityId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("librarycityId");

                    b.ToTable("libraries");
                });

            modelBuilder.Entity("iman_elahy_hw09.Models.Member", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("Genderindex")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NationalCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PhoneNumber")
                        .HasColumnType("int");

                    b.Property<DateTime>("RegistrationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("levelindex")
                        .HasColumnType("int");

                    b.Property<int>("libraryId")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("members");
                });

            modelBuilder.Entity("iman_elahy_hw09.Models.Book", b =>
                {
                    b.HasOne("iman_elahy_hw09.Models.Library", null)
                        .WithMany("Listbooks")
                        .HasForeignKey("libraryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("iman_elahy_hw09.Models.Library", b =>
                {
                    b.HasOne("iman_elahy_hw09.Models.City", "librarycity")
                        .WithMany()
                        .HasForeignKey("librarycityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("librarycity");
                });

            modelBuilder.Entity("iman_elahy_hw09.Models.Library", b =>
                {
                    b.Navigation("Listbooks");
                });
#pragma warning restore 612, 618
        }
    }
}
