using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Biblioteca.Migrations
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Empleado",
                table: "Empleado");

            migrationBuilder.RenameTable(
                name: "Empleado",
                newName: "Empleados");

            migrationBuilder.AddColumn<int>(
                name: "CarnetId",
                table: "Empleados",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Direccion",
                table: "Empleados",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ExperienciaLaboralId",
                table: "Empleados",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaNacimiento",
                table: "Empleados",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Identidad",
                table: "Empleados",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Nombre",
                table: "Empleados",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NumeroTelefono",
                table: "Empleados",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PrimerApellido",
                table: "Empleados",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Provincia",
                table: "Empleados",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SegundoApellido",
                table: "Empleados",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Empleados",
                table: "Empleados",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Carnets",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carnets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Empresas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CIF = table.Column<string>(nullable: true),
                    Direccion = table.Column<string>(nullable: true),
                    Nombre = table.Column<string>(nullable: true),
                    Provincia = table.Column<string>(nullable: true),
                    Telefono = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empresas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ExperienciaLaborales",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descripcion = table.Column<string>(nullable: true),
                    FechaFinal = table.Column<DateTime>(nullable: false),
                    FechaInicio = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExperienciaLaborales", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CodigoPath",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CarnetId = table.Column<int>(nullable: true),
                    Path = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CodigoPath", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CodigoPath_Carnets_CarnetId",
                        column: x => x.CarnetId,
                        principalTable: "Carnets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ofertas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descripcion = table.Column<string>(nullable: true),
                    EmpleadoId = table.Column<int>(nullable: true),
                    EmpresaId = table.Column<int>(nullable: true),
                    FechaInicio = table.Column<DateTime>(nullable: false),
                    NumeroCandidatos = table.Column<int>(nullable: false),
                    Provincia = table.Column<string>(nullable: true),
                    Titulo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ofertas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ofertas_Empleados_EmpleadoId",
                        column: x => x.EmpleadoId,
                        principalTable: "Empleados",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ofertas_Empresas_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EspecialidadPath",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ExperienciaLaboralId = table.Column<int>(nullable: true),
                    Path = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EspecialidadPath", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EspecialidadPath_ExperienciaLaborales_ExperienciaLaboralId",
                        column: x => x.ExperienciaLaboralId,
                        principalTable: "ExperienciaLaborales",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_CarnetId",
                table: "Empleados",
                column: "CarnetId");

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_ExperienciaLaboralId",
                table: "Empleados",
                column: "ExperienciaLaboralId");

            migrationBuilder.CreateIndex(
                name: "IX_CodigoPath_CarnetId",
                table: "CodigoPath",
                column: "CarnetId");

            migrationBuilder.CreateIndex(
                name: "IX_EspecialidadPath_ExperienciaLaboralId",
                table: "EspecialidadPath",
                column: "ExperienciaLaboralId");

            migrationBuilder.CreateIndex(
                name: "IX_Ofertas_EmpleadoId",
                table: "Ofertas",
                column: "EmpleadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Ofertas_EmpresaId",
                table: "Ofertas",
                column: "EmpresaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Empleados_Carnets_CarnetId",
                table: "Empleados",
                column: "CarnetId",
                principalTable: "Carnets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Empleados_ExperienciaLaborales_ExperienciaLaboralId",
                table: "Empleados",
                column: "ExperienciaLaboralId",
                principalTable: "ExperienciaLaborales",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Empleados_Carnets_CarnetId",
                table: "Empleados");

            migrationBuilder.DropForeignKey(
                name: "FK_Empleados_ExperienciaLaborales_ExperienciaLaboralId",
                table: "Empleados");

            migrationBuilder.DropTable(
                name: "CodigoPath");

            migrationBuilder.DropTable(
                name: "EspecialidadPath");

            migrationBuilder.DropTable(
                name: "Ofertas");

            migrationBuilder.DropTable(
                name: "Carnets");

            migrationBuilder.DropTable(
                name: "ExperienciaLaborales");

            migrationBuilder.DropTable(
                name: "Empresas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Empleados",
                table: "Empleados");

            migrationBuilder.DropIndex(
                name: "IX_Empleados_CarnetId",
                table: "Empleados");

            migrationBuilder.DropIndex(
                name: "IX_Empleados_ExperienciaLaboralId",
                table: "Empleados");

            migrationBuilder.DropColumn(
                name: "CarnetId",
                table: "Empleados");

            migrationBuilder.DropColumn(
                name: "Direccion",
                table: "Empleados");

            migrationBuilder.DropColumn(
                name: "ExperienciaLaboralId",
                table: "Empleados");

            migrationBuilder.DropColumn(
                name: "FechaNacimiento",
                table: "Empleados");

            migrationBuilder.DropColumn(
                name: "Identidad",
                table: "Empleados");

            migrationBuilder.DropColumn(
                name: "Nombre",
                table: "Empleados");

            migrationBuilder.DropColumn(
                name: "NumeroTelefono",
                table: "Empleados");

            migrationBuilder.DropColumn(
                name: "PrimerApellido",
                table: "Empleados");

            migrationBuilder.DropColumn(
                name: "Provincia",
                table: "Empleados");

            migrationBuilder.DropColumn(
                name: "SegundoApellido",
                table: "Empleados");

            migrationBuilder.RenameTable(
                name: "Empleados",
                newName: "Empleado");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Empleado",
                table: "Empleado",
                column: "Id");
        }
    }
}
