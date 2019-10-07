using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Biblioteca.Migrations
{
    public partial class AddCodigoPath : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CodigoPath_Carnets_CarnetId",
                table: "CodigoPath");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CodigoPath",
                table: "CodigoPath");

            migrationBuilder.RenameTable(
                name: "CodigoPath",
                newName: "CodigoPaths");

            migrationBuilder.RenameIndex(
                name: "IX_CodigoPath_CarnetId",
                table: "CodigoPaths",
                newName: "IX_CodigoPaths_CarnetId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CodigoPaths",
                table: "CodigoPaths",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CodigoPaths_Carnets_CarnetId",
                table: "CodigoPaths",
                column: "CarnetId",
                principalTable: "Carnets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CodigoPaths_Carnets_CarnetId",
                table: "CodigoPaths");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CodigoPaths",
                table: "CodigoPaths");

            migrationBuilder.RenameTable(
                name: "CodigoPaths",
                newName: "CodigoPath");

            migrationBuilder.RenameIndex(
                name: "IX_CodigoPaths_CarnetId",
                table: "CodigoPath",
                newName: "IX_CodigoPath_CarnetId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CodigoPath",
                table: "CodigoPath",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CodigoPath_Carnets_CarnetId",
                table: "CodigoPath",
                column: "CarnetId",
                principalTable: "Carnets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
