using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AppSocialTour.Data.Migrations
{
    public partial class TablaSocial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Social",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "TEXT", nullable: false),
                    Nombre = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Direccion = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Horario = table.Column<string>(type: "TEXT", nullable: false),
                    Telefono = table.Column<string>(type: "TEXT", maxLength: 15, nullable: true),
                    SitioWeb = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    Historia = table.Column<string>(type: "TEXT", maxLength: 1000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Social", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Social");
        }
    }
}
