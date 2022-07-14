using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AKeyBookWeb.Migrations
{
    public partial class MovieToCategoryMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Categories_movieId",
                table: "Movies");

            migrationBuilder.DropIndex(
                name: "IX_Movies_movieId",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "movieId",
                table: "Movies");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Categories",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Categories_CategoryId",
                table: "Categories",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Movies_CategoryId",
                table: "Categories",
                column: "CategoryId",
                principalTable: "Movies",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Movies_CategoryId",
                table: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Categories_CategoryId",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Categories");

            migrationBuilder.AddColumn<int>(
                name: "movieId",
                table: "Movies",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Movies_movieId",
                table: "Movies",
                column: "movieId");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Categories_movieId",
                table: "Movies",
                column: "movieId",
                principalTable: "Categories",
                principalColumn: "Id");
        }
    }
}
