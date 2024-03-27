using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppUsuario.Migrations
{
    public partial class carro : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Relampago Marquinhos",
                table: "Relampago Marquinhos");

            migrationBuilder.RenameTable(
                name: "Relampago Marquinhos",
                newName: "Carros");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataFabricacao",
                table: "Carros",
                type: "datetime2",
                maxLength: 80,
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldMaxLength: 80,
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Carros",
                table: "Carros",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Carros",
                table: "Carros");

            migrationBuilder.RenameTable(
                name: "Carros",
                newName: "Relampago Marquinhos");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataFabricacao",
                table: "Relampago Marquinhos",
                type: "datetime2",
                maxLength: 80,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldMaxLength: 80);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Relampago Marquinhos",
                table: "Relampago Marquinhos",
                column: "Id");
        }
    }
}
