using Microsoft.EntityFrameworkCore.Migrations;

namespace Prestadores_infrastructure.Migrations
{
    public partial class prestador : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.DropForeignKey(
                name: "FK_Prestadores_Servicos_ServiceProvidedId",
                table: "Prestadores");

            migrationBuilder.DropIndex(
                name: "IX_Prestadores_ServiceProvidedId",
                table: "Prestadores");

            migrationBuilder.DropColumn(
                name: "ServiceProvidedId",
                table: "Prestadores");

            migrationBuilder.AddColumn<int>(
                name: "ServiceProvidedId",
                table: "Prestadores",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Prestadores_ServiceProvidedId",
                table: "Prestadores",
                column: "ServiceProvidedId");

            migrationBuilder.AddForeignKey(
                name: "FK_Prestadores_Servicos_ServiceProvidedId",
                table: "Prestadores",
                column: "ServiceProvidedId",
                principalTable: "Servicos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
        }
    }
}
