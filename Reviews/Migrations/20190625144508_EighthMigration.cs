using Microsoft.EntityFrameworkCore.Migrations;

namespace Reviews.Migrations
{
    public partial class EighthMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 3,
                column: "ImageUrl",
                value: "SawOne.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 3,
                column: "ImageUrl",
                value: "Saw.jpg");
        }
    }
}
