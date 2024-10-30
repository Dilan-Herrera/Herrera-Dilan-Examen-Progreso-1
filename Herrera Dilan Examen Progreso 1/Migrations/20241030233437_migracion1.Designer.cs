﻿// <auto-generated />
using System;
using Herrera_Dilan_Examen_Progreso_1.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Herrera_Dilan_Examen_Progreso_1.Migrations
{
    [DbContext(typeof(Herrera_Dilan_Examen_Progreso_1Context))]
    [Migration("20241030233437_migracion1")]
    partial class migracion1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Herrera_Dilan_Examen_Progreso_1.Models.Celular", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Año")
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    b.Property<string>("Modelo")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("Precio")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Celular");
                });

            modelBuilder.Entity("Herrera_Dilan_Examen_Progreso_1.Models.Herrera", b =>
                {
                    b.Property<int>("Cedula")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Cedula"));

                    b.Property<bool?>("Estudiante")
                        .IsRequired()
                        .HasColumnType("bit");

                    b.Property<DateTime?>("FechaNacimiento")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<int>("IdCelular")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<double>("PesoKg")
                        .HasColumnType("float");

                    b.HasKey("Cedula");

                    b.HasIndex("IdCelular");

                    b.ToTable("Herrera");
                });

            modelBuilder.Entity("Herrera_Dilan_Examen_Progreso_1.Models.Herrera", b =>
                {
                    b.HasOne("Herrera_Dilan_Examen_Progreso_1.Models.Celular", "Celular")
                        .WithMany()
                        .HasForeignKey("IdCelular")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Celular");
                });
#pragma warning restore 612, 618
        }
    }
}