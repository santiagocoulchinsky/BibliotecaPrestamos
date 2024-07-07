﻿// <auto-generated />
using BibliotecaPrestamos.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BibliotecaPrestamos.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.6");

            modelBuilder.Entity("BibliotecaPrestamos.Model.Lector", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Lectores");
                });

            modelBuilder.Entity("BibliotecaPrestamos.Model.Libro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Estado")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Libros");
                });

            modelBuilder.Entity("BibliotecaPrestamos.Model.Prestamo", b =>
                {
                    b.Property<int>("LibroId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("LectorId")
                        .HasColumnType("INTEGER");

                    b.HasKey("LibroId", "LectorId");

                    b.HasIndex("LectorId");

                    b.ToTable("Prestamos");
                });

            modelBuilder.Entity("BibliotecaPrestamos.Model.Prestamo", b =>
                {
                    b.HasOne("BibliotecaPrestamos.Model.Lector", "Lector")
                        .WithMany("Libros")
                        .HasForeignKey("LectorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BibliotecaPrestamos.Model.Libro", "Libro")
                        .WithMany("Lectores")
                        .HasForeignKey("LibroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Lector");

                    b.Navigation("Libro");
                });

            modelBuilder.Entity("BibliotecaPrestamos.Model.Lector", b =>
                {
                    b.Navigation("Libros");
                });

            modelBuilder.Entity("BibliotecaPrestamos.Model.Libro", b =>
                {
                    b.Navigation("Lectores");
                });
#pragma warning restore 612, 618
        }
    }
}
