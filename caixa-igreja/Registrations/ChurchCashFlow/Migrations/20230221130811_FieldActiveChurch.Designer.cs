﻿// <auto-generated />
using ChurchCashFlow.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ChurchCashFlow.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230221130811_FieldActiveChurch")]
    partial class FieldActiveChurch
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ChurchCashFlow.Models.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Additional")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("VARCHAR")
                        .HasColumnName("Additional");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("VARCHAR")
                        .HasColumnName("City");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("VARCHAR")
                        .HasColumnName("Country");

                    b.Property<string>("District")
                        .HasMaxLength(30)
                        .HasColumnType("VARCHAR")
                        .HasColumnName("District");

                    b.Property<int>("Number")
                        .HasMaxLength(6)
                        .HasColumnType("int");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("VARCHAR")
                        .HasColumnName("State");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("VARCHAR")
                        .HasColumnName("Street");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("VARCHAR")
                        .HasColumnName("ZipCode");

                    b.HasKey("Id");

                    b.ToTable("Address", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Additional = "",
                            City = "São Lourenço",
                            Country = "Brasil",
                            District = "Centro",
                            Number = 780,
                            State = "Minas Gerais",
                            Street = "Rua Dr Ribeiro da Luz",
                            ZipCode = "37470-000"
                        },
                        new
                        {
                            Id = 2,
                            Additional = "Prédio 1",
                            City = "Itaguai",
                            Country = "Brasil",
                            District = "Mesquita",
                            Number = 258,
                            State = "Rio de Janeiro",
                            Street = "Avenida André Chaves",
                            ZipCode = "13710-000"
                        });
                });

            modelBuilder.Entity("ChurchCashFlow.Models.Church", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Active")
                        .HasColumnType("BIT")
                        .HasColumnName("Active");

                    b.Property<int>("AddressId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("VARCHAR")
                        .HasColumnName("Name");

                    b.HasKey("Id");

                    b.HasIndex("AddressId")
                        .IsUnique();

                    b.ToTable("Church", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Active = false,
                            AddressId = 1,
                            Name = "CEO São Lourenço"
                        },
                        new
                        {
                            Id = 2,
                            Active = false,
                            AddressId = 2,
                            Name = "CEP Cristina"
                        });
                });

            modelBuilder.Entity("ChurchCashFlow.Models.Church", b =>
                {
                    b.HasOne("ChurchCashFlow.Models.Address", "Address")
                        .WithOne()
                        .HasForeignKey("ChurchCashFlow.Models.Church", "AddressId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("Fk_Church_Address");

                    b.Navigation("Address");
                });
#pragma warning restore 612, 618
        }
    }
}
