using Microsoft.EntityFrameworkCore.Migrations;

namespace Prestadores_infrastructure.Migrations
{
    public partial class teste : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Prestadores_Servicos_ServiceProvidedId",
                table: "Prestadores");

            migrationBuilder.DropIndex(
                name: "IX_Prestadores_ServiceProvidedId",
                table: "Prestadores");

            migrationBuilder.AddColumn<int>(
                name: "ProvidedId",
                table: "Servicos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Servicos_ProvidedId",
                table: "Servicos",
                column: "ProvidedId");

            migrationBuilder.AddForeignKey(
                name: "FK_Servicos_Prestadores_ProvidedId",
                table: "Servicos",
                column: "ProvidedId",
                principalTable: "Prestadores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Servicos_Prestadores_ProvidedId",
                table: "Servicos");

            migrationBuilder.DropIndex(
                name: "IX_Servicos_ProvidedId",
                table: "Servicos");

            migrationBuilder.DropColumn(
                name: "ProvidedId",
                table: "Servicos");

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
    }
}
