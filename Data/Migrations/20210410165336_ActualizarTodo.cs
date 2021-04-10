using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AppSocialTour.Data.Migrations
{
    public partial class ActualizarTodo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SitioWeb",
                table: "Social");

            migrationBuilder.RenameColumn(
                name: "Historia",
                table: "Social",
                newName: "Datos");

            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "RestBar",
                newName: "TipoEmpresa");

            migrationBuilder.AddColumn<string>(
                name: "Categoria",
                table: "Social",
                type: "TEXT",
                maxLength: 1000,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "SitioWeb",
                table: "RestBar",
                type: "TEXT",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 100);

            migrationBuilder.AddColumn<string>(
                name: "NombreEmpresa",
                table: "RestBar",
                type: "TEXT",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Representante",
                table: "RestBar",
                type: "TEXT",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Cultura",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "TEXT", nullable: false),
                    Nombre = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Categoria = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Direccion = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Horario = table.Column<string>(type: "TEXT", nullable: false),
                    Historia = table.Column<string>(type: "TEXT", maxLength: 1000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cultura", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cultura");

            migrationBuilder.DropColumn(
                name: "Categoria",
                table: "Social");

            migrationBuilder.DropColumn(
                name: "NombreEmpresa",
                table: "RestBar");

            migrationBuilder.DropColumn(
                name: "Representante",
                table: "RestBar");

            migrationBuilder.RenameColumn(
                name: "Datos",
                table: "Social",
                newName: "Historia");

            migrationBuilder.RenameColumn(
                name: "TipoEmpresa",
                table: "RestBar",
                newName: "Nombre");

            migrationBuilder.AddColumn<string>(
                name: "SitioWeb",
                table: "Social",
                type: "TEXT",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SitioWeb",
                table: "RestBar",
                type: "TEXT",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 100,
                oldNullable: true);
        }
    }
}
