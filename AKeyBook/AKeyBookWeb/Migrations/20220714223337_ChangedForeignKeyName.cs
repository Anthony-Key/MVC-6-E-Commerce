using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AKeyBookWeb.Migrations
{
    public partial class ChangedForeignKeyName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Movies_CategoryId",
                table: "Categories");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "Categories",
                newName: "MovieId");

            migrationBuilder.RenameIndex(
                name: "IX_Categories_CategoryId",
                table: "Categories",
                newName: "IX_Categories_MovieId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Movies_MovieId",
                table: "Categories",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Movies_MovieId",
                table: "Categories");

            migrationBuilder.RenameColumn(
                name: "MovieId",
                table: "Categories",
                newName: "CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Categories_MovieId",
                table: "Categories",
                newName: "IX_Categories_CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Movies_CategoryId",
                table: "Categories",
                column: "CategoryId",
                principalTable: "Movies",
                principalColumn: "Id");
        }
    }
}
