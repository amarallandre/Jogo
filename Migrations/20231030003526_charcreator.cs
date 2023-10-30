using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Jogo.Migrations
{
    /// <inheritdoc />
    public partial class charcreator : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Nivel",
                table: "Personagens",
                newName: "Level");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Level",
                table: "Personagens",
                newName: "Nivel");
        }
    }
}
