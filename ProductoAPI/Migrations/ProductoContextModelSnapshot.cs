﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProductoAPI.Models;

#nullable disable

namespace ProductoAPI.Migrations
{
    [DbContext(typeof(ProductoContext))]
    partial class ProductoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ProductoAPI.Models.Producto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Categoria")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Productos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Categoria = "Electronica",
                            Descripcion = "Una laptop de alto rendimiento",
                            Nombre = "Laptop"
                        },
                        new
                        {
                            Id = 2,
                            Categoria = "Electronica",
                            Descripcion = "Un smartphone de nueva generacion",
                            Nombre = "Smartphone"
                        },
                        new
                        {
                            Id = 3,
                            Categoria = "Muebles",
                            Descripcion = "Una silla de escritorio comoda",
                            Nombre = "Silla de Escritorio"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
