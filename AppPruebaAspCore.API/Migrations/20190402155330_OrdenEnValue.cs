using Microsoft.EntityFrameworkCore.Migrations;

namespace AppPruebaAspCore.API.Migrations
{
    public partial class OrdenEnValue : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Orden",
                table: "Values",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Orden",
                table: "Values");
        }
    }
}
