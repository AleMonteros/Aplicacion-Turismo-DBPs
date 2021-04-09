using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AppSocialTour.Data.Migrations
{
    public partial class TablaPromociones : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Promocion",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "TEXT", nullable: false),
                    Promo = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false),
                    TipoNgeocio = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false),
                    NombreNegocio = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false),
                    Direccion = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false),
                    DatosPromo = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Promocion", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Promocion");
        }
    }
}
