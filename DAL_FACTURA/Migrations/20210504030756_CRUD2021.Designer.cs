// <auto-generated />
using System;
using DAL_FACTURA.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DAL_FACTURA.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210504030756_CRUD2021")]
    partial class CRUD2021
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DAL_FACTURA.Models.Factura", b =>
                {
                    b.Property<int>("idFactura")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("fechaProducto")
                        .HasColumnType("datetime2");

                    b.Property<int>("idProducto")
                        .HasColumnType("int");

                    b.HasKey("idFactura");

                    b.ToTable("Factura", "dbo");
                });
#pragma warning restore 612, 618
        }
    }
}
