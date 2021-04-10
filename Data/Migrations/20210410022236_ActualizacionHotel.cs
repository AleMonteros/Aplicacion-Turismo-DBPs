using Microsoft.EntityFrameworkCore.Migrations;

namespace AppSocialTour.Data.Migrations
{
    public partial class ActualizacionHotel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "Hotel",
                newName: "TipoEmpresa");

            migrationBuilder.AlterColumn<string>(
                name: "SitioWeb",
                table: "Hotel",
                type: "TEXT",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 100);

            migrationBuilder.AddColumn<string>(
                name: "NombreEmpresa",
                table: "Hotel",
                type: "TEXT",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Representante",
                table: "Hotel",
                type: "TEXT",
                maxLength: 50,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NombreEmpresa",
                table: "Hotel");

            migrationBuilder.DropColumn(
                name: "Representante",
                table: "Hotel");

            migrationBuilder.RenameColumn(
                name: "TipoEmpresa",
                table: "Hotel",
                newName: "Nombre");

            migrationBuilder.AlterColumn<string>(
                name: "SitioWeb",
                table: "Hotel",
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
