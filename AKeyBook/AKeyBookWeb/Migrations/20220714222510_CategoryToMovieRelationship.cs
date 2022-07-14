using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AKeyBookWeb.Migrations
{
    public partial class CategoryToMovieRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
