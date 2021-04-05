using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AppSocialTour.Data.Migrations
{
    public partial class NuevaTablaH : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hotel",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "TEXT", nullable: false),
                    Nombre = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Direccion = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Horario = table.Column<string>(type: "TEXT", nullable: false),
                    Telefono = table.Column<string>(type: "TEXT", maxLength: 15, nullable: false),
                    SitioWeb = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Datos = table.Column<string>(type: "TEXT", maxLength: 1000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hotel", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hotel");
        }
    }
}
