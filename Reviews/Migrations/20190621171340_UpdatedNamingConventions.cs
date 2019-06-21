using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Reviews.Migrations
{
    public partial class UpdatedNamingConventions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Categories_CategoryId",
                table: "Movies");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "HorrorReviews");

            migrationBuilder.DropIndex(
                name: "IX_Movies_CategoryId",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Movies");

            migrationBuilder.AddColumn<int>(
                name: "GenreId",
                table: "Movies",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    GenreId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    GenreName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.GenreId);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    ReviewId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Content = table.Column<string>(nullable: true),
                    MovieId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.ReviewId);
                    table.ForeignKey(
                        name: "FK_Reviews_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "MovieId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "GenreId", "GenreName" },
                values: new object[,]
                {
                    { 1, "Sci Fi" },
                    { 2, "Slasher" },
                    { 3, "Supernatural" }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewId", "Content", "MovieId" },
                values: new object[,]
                {
                    { 16, "Too weird, I didn't get what was going on. Made me want to visit my local petting zoo.", 8 },
                    { 15, "What Bobby said.", 8 },
                    { 14, "Good depiction of rural American family life, and the heartfelt dynamics between grandparents and their offspring.", 7 },
                    { 13, "Invoked a sense of wonder in regards to space travel and time. Renewed my belief in kind, caring extraterrestrial beings.", 7 },
                    { 12, "Yessssssssssssssssssssssssssss.", 6 },
                    { 11, "Oh boy... please don't watch this one.", 6 },
                    { 10, "Oh boy... please don't watch this one.", 5 },
                    { 9, "This sucks. My favorite actor wasn't in it.", 5 },
                    { 8, "Greeatest. Lovie. Ever. I mean Movie, not lovie.", 4 },
                    { 7, "Definitely a movie for animal lovers. Teaches you to trust the people around you, don't be a cynic. Hands down, the greatest horror movie ever made.", 4 },
                    { 6, "It was ok...", 3 },
                    { 5, "His inventions that brought people together inspired my creativity, and pushed me to put myself in new, uncomfortable situations. A must-see for all aspiring inventors.", 3 },
                    { 4, "Blech. I hated it.", 2 },
                    { 3, "A movie about the power of motherhood, in my opinion, one of the best examples of this.The strong religious themes with an emphasis on family values really spoke to me in a profound way.", 2 },
                    { 2, "Great Movie.!!", 1 },
                    { 1, "This is a great family movie, recommend you bring the kids, especially the young ones!Full of laughs, and life lessons too. As soon as we got out of the theatre, my six year old wanted to see it again!", 1 },
                    { 17, "Inspired me watch Fixer Upper and fix up my own house, to replicate the house's interactive, unique and cozy features.", 9 },
                    { 18, "A must-see.", 9 }
                });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 1,
                column: "GenreId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 2,
                column: "GenreId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 3,
                column: "GenreId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 4,
                column: "GenreId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 5,
                column: "GenreId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 6,
                column: "GenreId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 7,
                column: "GenreId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 8,
                column: "GenreId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 9,
                column: "GenreId",
                value: 3);

            migrationBuilder.CreateIndex(
                name: "IX_Movies_GenreId",
                table: "Movies",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_MovieId",
                table: "Reviews",
                column: "MovieId");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Genres_GenreId",
                table: "Movies",
                column: "GenreId",
                principalTable: "Genres",
                principalColumn: "GenreId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Genres_GenreId",
                table: "Movies");

            migrationBuilder.DropTable(
                name: "Genres");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropIndex(
                name: "IX_Movies_GenreId",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "GenreId",
                table: "Movies");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Movies",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CategoryName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "HorrorReviews",
                columns: table => new
                {
                    HorrorReviewsId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Content = table.Column<string>(nullable: true),
                    MovieId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HorrorReviews", x => x.HorrorReviewsId);
                    table.ForeignKey(
                        name: "FK_HorrorReviews_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "MovieId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "HorrorReviews",
                columns: new[] { "HorrorReviewsId", "Content", "MovieId" },
                values: new object[] { 1, "This is a great family movie, recommend you bring the kids, especially the young ones!Full of laughs, and life lessons too. As soon as we got out of the theatre, my six year old wanted to see it again!", 1 });

            migrationBuilder.InsertData(
                table: "HorrorReviews",
                columns: new[] { "HorrorReviewsId", "Content", "MovieId" },
                values: new object[] { 2, "King Lear", 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Movies_CategoryId",
                table: "Movies",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_HorrorReviews_MovieId",
                table: "HorrorReviews",
                column: "MovieId");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Categories_CategoryId",
                table: "Movies",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
