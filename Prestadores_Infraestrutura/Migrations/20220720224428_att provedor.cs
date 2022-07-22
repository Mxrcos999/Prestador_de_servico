using Microsoft.EntityFrameworkCore.Migrations;

namespace Prestadores_infrastructure.Migrations
{
    public partial class attprovedor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ServiceId",
                table: "Prestadores");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ServiceId",
                table: "Prestadores",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
