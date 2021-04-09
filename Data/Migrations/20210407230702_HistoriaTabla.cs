using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AppSocialTour.Data.Migrations
{
    public partial class HistoriaTabla : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Historia",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "TEXT", nullable: false),
                    Titulo = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Desarrollo = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false),
                    PaginasReferencia = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false),
                    Historiador = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    EmailHistoriador = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Historia", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Historia");
        }
    }
}
