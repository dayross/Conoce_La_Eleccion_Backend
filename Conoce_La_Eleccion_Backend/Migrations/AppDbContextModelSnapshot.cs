﻿// <auto-generated />
using System;
using Conoce_La_Eleccion_Backend.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Conoce_La_Eleccion_Backend.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Conoce_La_Eleccion_Backend.Models.Aspirante", b =>
                {
                    b.Property<int>("IdAspirante")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("IdAspirante"));

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("CargoIdCargo")
                        .HasColumnType("integer");

                    b.Property<int>("Edad")
                        .HasColumnType("integer");

                    b.Property<int>("IdCargo")
                        .HasColumnType("integer");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Presentacion")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("IdAspirante");

                    b.HasIndex("CargoIdCargo");

                    b.ToTable("Aspirante");
                });

            modelBuilder.Entity("Conoce_La_Eleccion_Backend.Models.Calificacion", b =>
                {
                    b.Property<int>("IdCalificacion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("IdCalificacion"));

                    b.Property<int>("AspiranteIdAspirante")
                        .HasColumnType("integer");

                    b.Property<int>("IdAspirante")
                        .HasColumnType("integer");

                    b.Property<int>("IdUsuario")
                        .HasColumnType("integer");

                    b.Property<int>("Puntuacion")
                        .HasColumnType("integer");

                    b.Property<int>("UsuarioIdUsuario")
                        .HasColumnType("integer");

                    b.HasKey("IdCalificacion");

                    b.HasIndex("AspiranteIdAspirante");

                    b.HasIndex("UsuarioIdUsuario");

                    b.ToTable("Calificacion");
                });

            modelBuilder.Entity("Conoce_La_Eleccion_Backend.Models.Cargo", b =>
                {
                    b.Property<int>("IdCargo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("IdCargo"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("IdCargo");

                    b.ToTable("Cargo");
                });

            modelBuilder.Entity("Conoce_La_Eleccion_Backend.Models.CorreoElectronico", b =>
                {
                    b.Property<int>("IdCorreoElectronico")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("IdCorreoElectronico"));

                    b.Property<int>("AspiranteIdAspirante")
                        .HasColumnType("integer");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("IdAspirante")
                        .HasColumnType("integer");

                    b.HasKey("IdCorreoElectronico");

                    b.HasIndex("AspiranteIdAspirante");

                    b.ToTable("CorreoElectronico");
                });

            modelBuilder.Entity("Conoce_La_Eleccion_Backend.Models.Educacion", b =>
                {
                    b.Property<int>("IdEducacion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("IdEducacion"));

                    b.Property<int>("AspiranteIdAspirante")
                        .HasColumnType("integer");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("FechaFin")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("IdAspirante")
                        .HasColumnType("integer");

                    b.Property<string>("ImpartidoPor")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("IdEducacion");

                    b.HasIndex("AspiranteIdAspirante");

                    b.ToTable("Educacion");
                });

            modelBuilder.Entity("Conoce_La_Eleccion_Backend.Models.Experiencia", b =>
                {
                    b.Property<int>("IDExperiencia")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("IDExperiencia"));

                    b.Property<int>("AspiranteIdAspirante")
                        .HasColumnType("integer");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("FechaFin")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("FechaInicio")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("IdAspirante")
                        .HasColumnType("integer");

                    b.Property<string>("LugarTrabajo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Puesto")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("IDExperiencia");

                    b.HasIndex("AspiranteIdAspirante");

                    b.ToTable("Experiencia");
                });

            modelBuilder.Entity("Conoce_La_Eleccion_Backend.Models.RedesSociales", b =>
                {
                    b.Property<int>("IdRedesSociales")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("IdRedesSociales"));

                    b.Property<int>("AspiranteIdAspirante")
                        .HasColumnType("integer");

                    b.Property<int>("IdAspirante")
                        .HasColumnType("integer");

                    b.Property<int>("IdTipoRedSocial")
                        .HasColumnType("integer");

                    b.Property<int>("TipoRedSocialIdTipoRedSocial")
                        .HasColumnType("integer");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("IdRedesSociales");

                    b.HasIndex("AspiranteIdAspirante");

                    b.HasIndex("TipoRedSocialIdTipoRedSocial");

                    b.ToTable("RedesSociales");
                });

            modelBuilder.Entity("Conoce_La_Eleccion_Backend.Models.Telefono", b =>
                {
                    b.Property<int>("IdTelefono")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("IdTelefono"));

                    b.Property<int>("AspiranteIdAspirante")
                        .HasColumnType("integer");

                    b.Property<int>("IdAspirante")
                        .HasColumnType("integer");

                    b.Property<int>("IdUsuario")
                        .HasColumnType("integer");

                    b.Property<string>("NumTelefono")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("UsuarioIdUsuario")
                        .HasColumnType("integer");

                    b.Property<bool>("Whatsapp")
                        .HasColumnType("boolean");

                    b.HasKey("IdTelefono");

                    b.HasIndex("AspiranteIdAspirante");

                    b.HasIndex("UsuarioIdUsuario");

                    b.ToTable("Telefono");
                });

            modelBuilder.Entity("Conoce_La_Eleccion_Backend.Models.TipoRedSocial", b =>
                {
                    b.Property<int>("IdTipoRedSocial")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("IdTipoRedSocial"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("IdTipoRedSocial");

                    b.ToTable("TipoRedSocial");
                });

            modelBuilder.Entity("Conoce_La_Eleccion_Backend.Models.Usuario", b =>
                {
                    b.Property<int>("IdUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("IdUsuario"));

                    b.Property<string>("Nickname")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("IdUsuario");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("Conoce_La_Eleccion_Backend.Models.Aspirante", b =>
                {
                    b.HasOne("Conoce_La_Eleccion_Backend.Models.Cargo", "Cargo")
                        .WithMany()
                        .HasForeignKey("CargoIdCargo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cargo");
                });

            modelBuilder.Entity("Conoce_La_Eleccion_Backend.Models.Calificacion", b =>
                {
                    b.HasOne("Conoce_La_Eleccion_Backend.Models.Aspirante", "Aspirante")
                        .WithMany()
                        .HasForeignKey("AspiranteIdAspirante")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Conoce_La_Eleccion_Backend.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioIdUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Aspirante");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Conoce_La_Eleccion_Backend.Models.CorreoElectronico", b =>
                {
                    b.HasOne("Conoce_La_Eleccion_Backend.Models.Aspirante", "Aspirante")
                        .WithMany()
                        .HasForeignKey("AspiranteIdAspirante")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Aspirante");
                });

            modelBuilder.Entity("Conoce_La_Eleccion_Backend.Models.Educacion", b =>
                {
                    b.HasOne("Conoce_La_Eleccion_Backend.Models.Aspirante", "Aspirante")
                        .WithMany()
                        .HasForeignKey("AspiranteIdAspirante")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Aspirante");
                });

            modelBuilder.Entity("Conoce_La_Eleccion_Backend.Models.Experiencia", b =>
                {
                    b.HasOne("Conoce_La_Eleccion_Backend.Models.Aspirante", "Aspirante")
                        .WithMany()
                        .HasForeignKey("AspiranteIdAspirante")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Aspirante");
                });

            modelBuilder.Entity("Conoce_La_Eleccion_Backend.Models.RedesSociales", b =>
                {
                    b.HasOne("Conoce_La_Eleccion_Backend.Models.Aspirante", "Aspirante")
                        .WithMany()
                        .HasForeignKey("AspiranteIdAspirante")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Conoce_La_Eleccion_Backend.Models.TipoRedSocial", "TipoRedSocial")
                        .WithMany()
                        .HasForeignKey("TipoRedSocialIdTipoRedSocial")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Aspirante");

                    b.Navigation("TipoRedSocial");
                });

            modelBuilder.Entity("Conoce_La_Eleccion_Backend.Models.Telefono", b =>
                {
                    b.HasOne("Conoce_La_Eleccion_Backend.Models.Aspirante", "Aspirante")
                        .WithMany()
                        .HasForeignKey("AspiranteIdAspirante")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Conoce_La_Eleccion_Backend.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioIdUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Aspirante");

                    b.Navigation("Usuario");
                });
#pragma warning restore 612, 618
        }
    }
}
