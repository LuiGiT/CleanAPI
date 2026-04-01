using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DientesLimpios.Persistencia.Migrations
{
    /// <inheritdoc />
    public partial class TablePacientes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Consultorios",
                table: "Consultorios");

            migrationBuilder.RenameTable(
                name: "Consultorios",
                newName: "Consultorio");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Consultorio",
                table: "Consultorio",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Paciente",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(254)", maxLength: 254, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paciente", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Paciente");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Consultorio",
                table: "Consultorio");

            migrationBuilder.RenameTable(
                name: "Consultorio",
                newName: "Consultorios");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Consultorios",
                table: "Consultorios",
                column: "Id");
        }
    }
}
