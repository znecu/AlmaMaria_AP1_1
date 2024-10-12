﻿// <auto-generated />
using System;
using AlmaMaria_AP1_1.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AlmaMaria_AP1_1.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.8");

            modelBuilder.Entity("AlmaMaria_AP1_1.Models.CobroDetalle", b =>
                {
                    b.Property<int>("DetalleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CobroId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PrestamoId")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("ValorCobrado")
                        .HasColumnType("TEXT");

                    b.HasKey("DetalleId");

                    b.HasIndex("CobroId");

                    b.HasIndex("PrestamoId");

                    b.ToTable("CobroDetalle");
                });

            modelBuilder.Entity("AlmaMaria_AP1_1.Models.Cobros", b =>
                {
                    b.Property<int>("CobroId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("DeudorId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Monto")
                        .HasColumnType("TEXT");

                    b.HasKey("CobroId");

                    b.HasIndex("DeudorId");

                    b.ToTable("Cobros");
                });

            modelBuilder.Entity("AlmaMaria_AP1_1.Models.Deudores", b =>
                {
                    b.Property<int>("DeudorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nombres")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("DeudorId");

                    b.ToTable("Deudores");

                    b.HasData(
                        new
                        {
                            DeudorId = 1,
                            Nombres = "Alma"
                        },
                        new
                        {
                            DeudorId = 2,
                            Nombres = "Jane"
                        },
                        new
                        {
                            DeudorId = 3,
                            Nombres = "DjMarte"
                        },
                        new
                        {
                            DeudorId = 4,
                            Nombres = "Ronell"
                        },
                        new
                        {
                            DeudorId = 5,
                            Nombres = "Franniel"
                        });
                });

            modelBuilder.Entity("AlmaMaria_AP1_1.Models.Prestamos", b =>
                {
                    b.Property<int>("PrestamoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Balance")
                        .HasColumnType("TEXT");

                    b.Property<int?>("CobrosCobroId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Concepto")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("DeudorId")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Monto")
                        .HasColumnType("TEXT");

                    b.HasKey("PrestamoId");

                    b.HasIndex("CobrosCobroId");

                    b.HasIndex("DeudorId");

                    b.ToTable("Prestamos");
                });

            modelBuilder.Entity("AlmaMaria_AP1_1.Models.CobroDetalle", b =>
                {
                    b.HasOne("AlmaMaria_AP1_1.Models.Cobros", "Cobros")
                        .WithMany("CobroDetalle")
                        .HasForeignKey("CobroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AlmaMaria_AP1_1.Models.Prestamos", "Prestamo")
                        .WithMany("CobrosDetalle")
                        .HasForeignKey("PrestamoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cobros");

                    b.Navigation("Prestamo");
                });

            modelBuilder.Entity("AlmaMaria_AP1_1.Models.Cobros", b =>
                {
                    b.HasOne("AlmaMaria_AP1_1.Models.Deudores", "Deudores")
                        .WithMany()
                        .HasForeignKey("DeudorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Deudores");
                });

            modelBuilder.Entity("AlmaMaria_AP1_1.Models.Prestamos", b =>
                {
                    b.HasOne("AlmaMaria_AP1_1.Models.Cobros", "Cobros")
                        .WithMany()
                        .HasForeignKey("CobrosCobroId");

                    b.HasOne("AlmaMaria_AP1_1.Models.Deudores", "Deudores")
                        .WithMany()
                        .HasForeignKey("DeudorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cobros");

                    b.Navigation("Deudores");
                });

            modelBuilder.Entity("AlmaMaria_AP1_1.Models.Cobros", b =>
                {
                    b.Navigation("CobroDetalle");
                });

            modelBuilder.Entity("AlmaMaria_AP1_1.Models.Prestamos", b =>
                {
                    b.Navigation("CobrosDetalle");
                });
#pragma warning restore 612, 618
        }
    }
}
