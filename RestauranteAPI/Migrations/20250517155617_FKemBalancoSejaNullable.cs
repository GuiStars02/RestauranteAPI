using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestauranteAPI.Migrations
{
    /// <inheritdoc />
    public partial class FKemBalancoSejaNullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Balanco_Prato_IdPrato",
                table: "Balanco");

            migrationBuilder.AlterColumn<int>(
                name: "IdPrato",
                table: "Balanco",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Balanco_Prato_IdPrato",
                table: "Balanco",
                column: "IdPrato",
                principalTable: "Prato",
                principalColumn: "IdPrato");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Balanco_Prato_IdPrato",
                table: "Balanco");

            migrationBuilder.AlterColumn<int>(
                name: "IdPrato",
                table: "Balanco",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Balanco_Prato_IdPrato",
                table: "Balanco",
                column: "IdPrato",
                principalTable: "Prato",
                principalColumn: "IdPrato",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
