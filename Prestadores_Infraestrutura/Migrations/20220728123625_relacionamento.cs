using Microsoft.EntityFrameworkCore.Migrations;

namespace Prestadores_infrastructure.Migrations
{
    public partial class relacionamento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Servicos_Prestadores_ProvideedId",
                table: "Servicos");

            migrationBuilder.DropIndex(
                name: "IX_Servicos_ProvideedId",
                table: "Servicos");

            migrationBuilder.DropColumn(
                name: "ProvideedId",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Prestadores_Servicos_ServiceProvidedId",
                table: "Prestadores");

            migrationBuilder.DropIndex(
                name: "IX_Prestadores_ServiceProvidedId",
                table: "Prestadores");

            migrationBuilder.AddColumn<int>(
                name: "ProvideedId",
                table: "Servicos",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Servicos_ProvideedId",
                table: "Servicos",
                column: "ProvideedId");

            migrationBuilder.AddForeignKey(
                name: "FK_Servicos_Prestadores_ProvideedId",
                table: "Servicos",
                column: "ProvideedId",
                principalTable: "Prestadores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
