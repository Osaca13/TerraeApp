﻿// <auto-generated />
using Biblioteca;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace Biblioteca.Migrations
{
    [DbContext(typeof(BibliotecaContext))]
    [Migration("20191007131747_AddCodigoPath")]
    partial class AddCodigoPath
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Biblioteca.Modelo.AplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Contraseña")
                        .IsRequired();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NombreUsuario")
                        .IsRequired();

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Biblioteca.Modelo.Carnet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.HasKey("Id");

                    b.ToTable("Carnets");
                });

            modelBuilder.Entity("Biblioteca.Modelo.CodigoPath", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CarnetId");

                    b.Property<string>("Path");

                    b.HasKey("Id");

                    b.HasIndex("CarnetId");

                    b.ToTable("CodigoPaths");
                });

            modelBuilder.Entity("Biblioteca.Modelo.Empleado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CarnetId");

                    b.Property<string>("Direccion");

                    b.Property<int?>("ExperienciaLaboralId");

                    b.Property<DateTime>("FechaNacimiento");

                    b.Property<string>("Identidad");

                    b.Property<string>("Nombre");

                    b.Property<string>("NumeroTelefono");

                    b.Property<string>("PrimerApellido");

                    b.Property<string>("Provincia");

                    b.Property<string>("SegundoApellido");

                    b.HasKey("Id");

                    b.HasIndex("CarnetId");

                    b.HasIndex("ExperienciaLaboralId");

                    b.ToTable("Empleados");
                });

            modelBuilder.Entity("Biblioteca.Modelo.Empresa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CIF");

                    b.Property<string>("Direccion");

                    b.Property<string>("Nombre");

                    b.Property<string>("Provincia");

                    b.Property<int>("Telefono");

                    b.HasKey("Id");

                    b.ToTable("Empresas");
                });

            modelBuilder.Entity("Biblioteca.Modelo.EspecialidadPath", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ExperienciaLaboralId");

                    b.Property<string>("Path");

                    b.HasKey("Id");

                    b.HasIndex("ExperienciaLaboralId");

                    b.ToTable("EspecialidadPath");
                });

            modelBuilder.Entity("Biblioteca.Modelo.ExperienciaLaboral", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descripcion");

                    b.Property<DateTime>("FechaFinal");

                    b.Property<DateTime>("FechaInicio");

                    b.HasKey("Id");

                    b.ToTable("ExperienciaLaborales");
                });

            modelBuilder.Entity("Biblioteca.Modelo.Oferta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descripcion");

                    b.Property<int?>("EmpleadoId");

                    b.Property<int?>("EmpresaId");

                    b.Property<DateTime>("FechaInicio");

                    b.Property<int>("NumeroCandidatos");

                    b.Property<string>("Provincia");

                    b.Property<string>("Titulo");

                    b.HasKey("Id");

                    b.HasIndex("EmpleadoId");

                    b.HasIndex("EmpresaId");

                    b.ToTable("Ofertas");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Biblioteca.Modelo.CodigoPath", b =>
                {
                    b.HasOne("Biblioteca.Modelo.Carnet")
                        .WithMany("Codigo")
                        .HasForeignKey("CarnetId");
                });

            modelBuilder.Entity("Biblioteca.Modelo.Empleado", b =>
                {
                    b.HasOne("Biblioteca.Modelo.Carnet", "Carnet")
                        .WithMany()
                        .HasForeignKey("CarnetId");

                    b.HasOne("Biblioteca.Modelo.ExperienciaLaboral", "ExperienciaLaboral")
                        .WithMany()
                        .HasForeignKey("ExperienciaLaboralId");
                });

            modelBuilder.Entity("Biblioteca.Modelo.EspecialidadPath", b =>
                {
                    b.HasOne("Biblioteca.Modelo.ExperienciaLaboral")
                        .WithMany("Especialidad")
                        .HasForeignKey("ExperienciaLaboralId");
                });

            modelBuilder.Entity("Biblioteca.Modelo.Oferta", b =>
                {
                    b.HasOne("Biblioteca.Modelo.Empleado")
                        .WithMany("Oferta")
                        .HasForeignKey("EmpleadoId");

                    b.HasOne("Biblioteca.Modelo.Empresa", "Empresa")
                        .WithMany("Oferta")
                        .HasForeignKey("EmpresaId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Biblioteca.Modelo.AplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Biblioteca.Modelo.AplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Biblioteca.Modelo.AplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Biblioteca.Modelo.AplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
