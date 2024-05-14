using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PruebaNet.Migrations
{
    /// <inheritdoc />
    public partial class initDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Area",
                table: "Empleado");

            migrationBuilder.AddColumn<int>(
                name: "IdArea",
                table: "Empleado",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Area",
                columns: table => new
                {
                    IdArea = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreArea = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Area", x => x.IdArea);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Empleado_IdArea",
                table: "Empleado",
                column: "IdArea");

            migrationBuilder.AddForeignKey(
                name: "FK_Empleado_Area_IdArea",
                table: "Empleado",
                column: "IdArea",
                principalTable: "Area",
                principalColumn: "IdArea",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Empleado_Area_IdArea",
                table: "Empleado");

            migrationBuilder.DropTable(
                name: "Area");

            migrationBuilder.DropIndex(
                name: "IX_Empleado_IdArea",
                table: "Empleado");

            migrationBuilder.DropColumn(
                name: "IdArea",
                table: "Empleado");

            migrationBuilder.AddColumn<string>(
                name: "Area",
                table: "Empleado",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
