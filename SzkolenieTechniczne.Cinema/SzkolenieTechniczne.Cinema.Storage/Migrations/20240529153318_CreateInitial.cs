using Microsoft.EntityFrameworkCore.Migrations;

namespace SzkolenieTechniczne.Cinema.Storage.Migrations
{
    public partial class CreateInitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_MovieCategories_MovieCategoriesId",
                schema: "Cinema",
                table: "Movies");

            migrationBuilder.DropTable(
                name: "MovieCategories",
                schema: "Cinema");

            migrationBuilder.DropIndex(
                name: "IX_Movies_MovieCategoriesId",
                schema: "Cinema",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "MovieCategoriesId",
                schema: "Cinema",
                table: "Movies");

            migrationBuilder.CreateTable(
                name: "MovieCategory",
                schema: "Cinema",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieCategory", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Movies_MovieCategoryId",
                schema: "Cinema",
                table: "Movies",
                column: "MovieCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_MovieCategory_MovieCategoryId",
                schema: "Cinema",
                table: "Movies",
                column: "MovieCategoryId",
                principalSchema: "Cinema",
                principalTable: "MovieCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_MovieCategory_MovieCategoryId",
                schema: "Cinema",
                table: "Movies");

            migrationBuilder.DropTable(
                name: "MovieCategory",
                schema: "Cinema");

            migrationBuilder.DropIndex(
                name: "IX_Movies_MovieCategoryId",
                schema: "Cinema",
                table: "Movies");

            migrationBuilder.AddColumn<long>(
                name: "MovieCategoriesId",
                schema: "Cinema",
                table: "Movies",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "MovieCategories",
                schema: "Cinema",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieCategories", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Movies_MovieCategoriesId",
                schema: "Cinema",
                table: "Movies",
                column: "MovieCategoriesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_MovieCategories_MovieCategoriesId",
                schema: "Cinema",
                table: "Movies",
                column: "MovieCategoriesId",
                principalSchema: "Cinema",
                principalTable: "MovieCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
