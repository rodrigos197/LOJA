using Microsoft.EntityFrameworkCore.Migrations;

namespace LOJA.Migrations
{
    public partial class InitBd2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Stock",
                table: "Clients",
                newName: "Hours");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Hours",
                table: "Clients",
                newName: "Stock");
        }
    }
}
