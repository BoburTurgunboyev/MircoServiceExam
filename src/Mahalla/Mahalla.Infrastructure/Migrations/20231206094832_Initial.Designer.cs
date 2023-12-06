﻿// <auto-generated />
using Mahalla.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Mahalla.Infrastructure.Migrations
{
    [DbContext(typeof(AppBbContect))]
    [Migration("20231206094832_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Mahalla.Domain.Entities.MahallaKamitet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CityName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MahallaName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RaisId")
                        .HasColumnType("int");

                    b.Property<string>("RegionName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MahallaKamitets");
                });

            modelBuilder.Entity("Mahalla.Domain.Entities.Odam", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HomeNumber")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OdamMale")
                        .HasColumnType("int");

                    b.Property<int>("OilaId")
                        .HasColumnType("int");

                    b.Property<string>("StreetName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("OilaId");

                    b.ToTable("Odams");
                });

            modelBuilder.Entity("Mahalla.Domain.Entities.Oila", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("MahallaKamitetId")
                        .HasColumnType("int");

                    b.Property<int>("member")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MahallaKamitetId");

                    b.ToTable("Oilas");
                });

            modelBuilder.Entity("Mahalla.Domain.Entities.Rais", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MahallaKamitetId")
                        .HasColumnType("int");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RaisMale")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MahallaKamitetId")
                        .IsUnique();

                    b.ToTable("Raiss");
                });

            modelBuilder.Entity("Mahalla.Domain.Entities.Odam", b =>
                {
                    b.HasOne("Mahalla.Domain.Entities.Oila", "Oila")
                        .WithMany("Odams")
                        .HasForeignKey("OilaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Oila");
                });

            modelBuilder.Entity("Mahalla.Domain.Entities.Oila", b =>
                {
                    b.HasOne("Mahalla.Domain.Entities.MahallaKamitet", "MahallaKamitet")
                        .WithMany("Oilas")
                        .HasForeignKey("MahallaKamitetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MahallaKamitet");
                });

            modelBuilder.Entity("Mahalla.Domain.Entities.Rais", b =>
                {
                    b.HasOne("Mahalla.Domain.Entities.MahallaKamitet", "MahallaKamitet")
                        .WithOne("Rais")
                        .HasForeignKey("Mahalla.Domain.Entities.Rais", "MahallaKamitetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MahallaKamitet");
                });

            modelBuilder.Entity("Mahalla.Domain.Entities.MahallaKamitet", b =>
                {
                    b.Navigation("Oilas");

                    b.Navigation("Rais")
                        .IsRequired();
                });

            modelBuilder.Entity("Mahalla.Domain.Entities.Oila", b =>
                {
                    b.Navigation("Odams");
                });
#pragma warning restore 612, 618
        }
    }
}