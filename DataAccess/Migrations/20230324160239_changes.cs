using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class changes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Faculties_Univeristies_UniversityCode",
                table: "Faculties");

            migrationBuilder.DropIndex(
                name: "IX_Faculties_UniversityCode",
                table: "Faculties");

            migrationBuilder.DropColumn(
                name: "UniversityCode",
                table: "Faculties");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UniversityCode",
                table: "Faculties",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Faculties_UniversityCode",
                table: "Faculties",
                column: "UniversityCode");

            migrationBuilder.AddForeignKey(
                name: "FK_Faculties_Univeristies_UniversityCode",
                table: "Faculties",
                column: "UniversityCode",
                principalTable: "Univeristies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
