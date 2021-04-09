using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AppSocialTour.Data.Migrations
{
    public partial class TablaNovedad : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Novedad",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "TEXT", nullable: false),
                    Noticia = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false),
                    Lugar = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false),
                    Direccion = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false),
                    Mensaje = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Novedad", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Novedad");
        }
    }
}
