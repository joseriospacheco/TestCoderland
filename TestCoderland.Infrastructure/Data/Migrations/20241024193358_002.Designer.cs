﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using TestCoderland.Infrastructure.Data;

#nullable disable

namespace TestCoderland.Infrastructure.Data.Migrations
{
    [DbContext(typeof(CoderlandDbContext))]
    [Migration("20241024193358_002")]
    partial class _002
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("TestCoderland.Core.Entities.MarcaAuto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PaisOrigen")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("marcas_de_autos", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nombre = "Toyota",
                            PaisOrigen = "Japón"
                        },
                        new
                        {
                            Id = 2,
                            Nombre = "Ford",
                            PaisOrigen = "Estados Unidos"
                        },
                        new
                        {
                            Id = 3,
                            Nombre = "Renault",
                            PaisOrigen = "Francia"
                        },
                        new
                        {
                            Id = 4,
                            Nombre = "Kia",
                            PaisOrigen = "Corea del Sur"
                        },
                        new
                        {
                            Id = 5,
                            Nombre = "Chevrolet",
                            PaisOrigen = "Estados Unidos"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
