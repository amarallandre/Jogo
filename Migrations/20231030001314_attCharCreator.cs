using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Jogo.Migrations
{
    /// <inheritdoc />
    public partial class attCharCreator : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Dano",
                table: "Personagens",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DanoBase",
                table: "Personagens",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Defesa",
                table: "Personagens",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DefesaBase",
                table: "Personagens",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Exp",
                table: "Personagens",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "HP",
                table: "Personagens",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "HPBase",
                table: "Personagens",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MP",
                table: "Personagens",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MPBase",
                table: "Personagens",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Nivel",
                table: "Personagens",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Dano",
                table: "Personagens");

            migrationBuilder.DropColumn(
                name: "DanoBase",
                table: "Personagens");

            migrationBuilder.DropColumn(
                name: "Defesa",
                table: "Personagens");

            migrationBuilder.DropColumn(
                name: "DefesaBase",
                table: "Personagens");

            migrationBuilder.DropColumn(
                name: "Exp",
                table: "Personagens");

            migrationBuilder.DropColumn(
                name: "HP",
                table: "Personagens");

            migrationBuilder.DropColumn(
                name: "HPBase",
                table: "Personagens");

            migrationBuilder.DropColumn(
                name: "MP",
                table: "Personagens");

            migrationBuilder.DropColumn(
                name: "MPBase",
                table: "Personagens");

            migrationBuilder.DropColumn(
                name: "Nivel",
                table: "Personagens");
        }
    }
}
