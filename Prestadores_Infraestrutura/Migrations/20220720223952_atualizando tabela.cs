using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace Prestadores_infrastructure.Migrations
{
    public partial class atualizandotabela : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Service",
                table: "Prestadores");

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Prestadores",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddColumn<int>(
                name: "ServiceId",
                table: "Prestadores",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ServiceProvidedId",
                table: "Prestadores",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Servicos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    DateHourRegister = table.Column<DateTime>(type: "datetime", nullable: false),
                    DateHourChange = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servicos", x => x.Id);
                });

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
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Prestadores_Servicos_ServiceProvidedId",
                table: "Prestadores");

            migrationBuilder.DropTable(
                name: "Servicos");

            migrationBuilder.DropIndex(
                name: "IX_Prestadores_ServiceProvidedId",
                table: "Prestadores");

            migrationBuilder.DropColumn(
                name: "ServiceId",
                table: "Prestadores");

            migrationBuilder.DropColumn(
                name: "ServiceProvidedId",
                table: "Prestadores");

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Prestadores",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Service",
                table: "Prestadores",
                type: "text",
                nullable: false);
        }
    }
}
