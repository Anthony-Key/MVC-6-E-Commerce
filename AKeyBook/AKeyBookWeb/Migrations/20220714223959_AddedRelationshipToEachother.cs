using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AKeyBookWeb.Migrations
{
    public partial class AddedRelationshipToEachother : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Movies_MovieId",
                table: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Categories_MovieId",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "MovieId",
                table: "Categories");

            migrationBuilder.CreateTable(
                name: "CategoryMovie",
                columns: table => new
                {
                    CategoriesId = table.Column<int>(type: "int", nullable: false),
                    MoviesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryMovie", x => new { x.CategoriesId, x.MoviesId });
                    table.ForeignKey(
                        name: "FK_CategoryMovie_Categories_CategoriesId",
                        column: x => x.CategoriesId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryMovie_Movies_MoviesId",
                        column: x => x.MoviesId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CategoryMovie_MoviesId",
                table: "CategoryMovie",
                column: "MoviesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoryMovie");

            migrationBuilder.AddColumn<int>(
                name: "MovieId",
                table: "Categories",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Categories_MovieId",
                table: "Categories",
                column: "MovieId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Movies_MovieId",
                table: "Categories",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id");
        }
    }
}
