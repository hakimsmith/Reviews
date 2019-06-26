using Microsoft.EntityFrameworkCore.Migrations;

namespace Reviews.Migrations
{
    public partial class FourthMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "MovieId", "CategoryId", "Description", "ImageUrl", "Title" },
                values: new object[,]
                {
                    { 111, null, "1999 American supernatural horror film written, directed and edited by Daniel Myrick Eduardo Sanchez.", "BlairWitch.jpg", "Blair Witch Project" },
                    { 222, null, "2018 American psychological horror drama film written and directed by  Ari Aster.", "Hereditary.jpg", "Hereditary" },
                    { 333, null, "2004 American psychological horror-thriller filmed and directed by James Wan.", "Saw.jpg", "Saw" },
                    { 444, null, "1982 science fiction horror film directed by John Carpenter.", "TheThing.jpg", "The Thing" },
                    { 555, null, "War of the Worlds, 2005 American science-fiction action film directed by Steven Spielberg and written by Josh Friedman and David Koepp, loosely based on the 1898 novel of the same title by H. G. Wells", "WarofWorlds.jpg", "War of the Worlds" },
                    { 666, null, "1997 film. In 2047 a group of astronauts are sent to investigate and salvage the starship ‘Event Horizon’ which disappeared mysteriously 7 years before on its maiden voyage. With its return, the crew of the ‘Lewis and Clark’ discovers the real truth behind the disappearance of the ‘Event Horizon’ – and something even more terrifying.", "EventHorizon.jpg", "Event Horizon" },
                    { 777, null, "1974 film, Five friends visiting their grandfather’s house in the country are hunted and terrorized by a chain-saw wielding killer and his family of grave-robbing cannibals.", "TexasChainsaw.jpg", "Texas Chainsaw Massacre" },
                    { 888, null, "2012 American horror comedy film directed by Drew Goddard in his directorial debut, produced by Joss Whedon, and written by Whedon and Goddard.", "CabinInWoods.png", "Cabin in the Woods" },
                    { 999, null, "2007 film. After a young, middle class couple moves into a suburban ‘starter’ tract house, they become increasingly disturbed by a presence that may or may not be somehow demonic but is certainly most active in the middle of the night. Especially when they sleep. Or try to.", "ParanormalActivity.jpg", "Paranormal Activity" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 444);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 555);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 666);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 777);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 888);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 999);
        }
    }
}
