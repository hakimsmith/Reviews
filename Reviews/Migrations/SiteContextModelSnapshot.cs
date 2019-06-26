﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Reviews;

namespace Reviews.Migrations
{
    [DbContext(typeof(SiteContext))]
    partial class SiteContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Reviews.Model.Genre", b =>
                {
                    b.Property<int>("GenreId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("GenreName");

                    b.Property<string>("ImageUrl");

                    b.HasKey("GenreId");

                    b.ToTable("Genres");

                    b.HasData(
                        new { GenreId = 1, GenreName = "Sci Fi", ImageUrl = "SciFi.jpg" },
                        new { GenreId = 2, GenreName = "Slasher", ImageUrl = "Slasher.jpg" },
                        new { GenreId = 3, GenreName = "Supernatural", ImageUrl = "Supernatural.jpg" }
                    );
                });

            modelBuilder.Entity("Reviews.Model.Movie", b =>
                {
                    b.Property<int>("MovieId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<int>("GenreId");

                    b.Property<string>("ImageUrl");

                    b.Property<string>("Title");

                    b.HasKey("MovieId");

                    b.HasIndex("GenreId");

                    b.ToTable("Movies");

                    b.HasData(
                        new { MovieId = 1, Description = "1999 American supernatural horror film written, directed and edited by Daniel Myrick Eduardo Sanchez.", GenreId = 3, ImageUrl = "BlairWitch.jpg", Title = "Blair Witch Project" },
                        new { MovieId = 2, Description = "2018 American psychological horror drama film written and directed by  Ari Aster.", GenreId = 3, ImageUrl = "Hereditary.jpg", Title = "Hereditary" },
                        new { MovieId = 3, Description = "2004 American psychological horror-thriller filmed and directed by James Wan.", GenreId = 2, ImageUrl = "SawOne.jpg", Title = "Saw" },
                        new { MovieId = 4, Description = "1982 science fiction horror film directed by John Carpenter.", GenreId = 1, ImageUrl = "TheThing.jpg", Title = "The Thing" },
                        new { MovieId = 5, Description = "War of the Worlds, 2005 American science-fiction action film directed by Steven Spielberg and written by Josh Friedman and David Koepp, loosely based on the 1898 novel of the same title by H. G. Wells", GenreId = 1, ImageUrl = "WarofWorlds.jpg", Title = "War of the Worlds" },
                        new { MovieId = 6, Description = "1997 film. In 2047 a group of astronauts are sent to investigate and salvage the starship ‘Event Horizon’ which disappeared mysteriously 7 years before on its maiden voyage. With its return, the crew of the ‘Lewis and Clark’ discovers the real truth behind the disappearance of the ‘Event Horizon’ – and something even more terrifying.", GenreId = 1, ImageUrl = "EventHorizon.jpg", Title = "Event Horizon" },
                        new { MovieId = 7, Description = "1974 film, Five friends visiting their grandfather’s house in the country are hunted and terrorized by a chain-saw wielding killer and his family of grave-robbing cannibals.", GenreId = 2, ImageUrl = "TexasChainsaw.jpg", Title = "Texas Chainsaw Massacre" },
                        new { MovieId = 8, Description = "2012 American horror comedy film directed by Drew Goddard in his directorial debut, produced by Joss Whedon, and written by Whedon and Goddard.", GenreId = 2, ImageUrl = "CabinInWoods.png", Title = "Cabin in the Woods" },
                        new { MovieId = 9, Description = "2007 film. After a young, middle class couple moves into a suburban ‘starter’ tract house, they become increasingly disturbed by a presence that may or may not be somehow demonic but is certainly most active in the middle of the night. Especially when they sleep. Or try to.", GenreId = 3, ImageUrl = "ParanormalActivity.jpg", Title = "Paranormal Activity" }
                    );
                });

            modelBuilder.Entity("Reviews.Model.Review", b =>
                {
                    b.Property<int>("ReviewId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content");

                    b.Property<int>("MovieId");

                    b.HasKey("ReviewId");

                    b.HasIndex("MovieId");

                    b.ToTable("Reviews");

                    b.HasData(
                        new { ReviewId = 1, Content = "This is a great family movie, recommend you bring the kids, especially the young ones!Full of laughs, and life lessons too. As soon as we got out of the theatre, my six year old wanted to see it again!", MovieId = 1 },
                        new { ReviewId = 2, Content = "Great Movie.!!", MovieId = 1 },
                        new { ReviewId = 3, Content = "A movie about the power of motherhood, in my opinion, one of the best examples of this.The strong religious themes with an emphasis on family values really spoke to me in a profound way.", MovieId = 2 },
                        new { ReviewId = 4, Content = "Blech. I hated it.", MovieId = 2 },
                        new { ReviewId = 5, Content = "His inventions that brought people together inspired my creativity, and pushed me to put myself in new, uncomfortable situations. A must-see for all aspiring inventors.", MovieId = 3 },
                        new { ReviewId = 6, Content = "It was ok...", MovieId = 3 },
                        new { ReviewId = 7, Content = "Definitely a movie for animal lovers. Teaches you to trust the people around you, don't be a cynic. Hands down, the greatest horror movie ever made.", MovieId = 4 },
                        new { ReviewId = 8, Content = "Greeatest. Lovie. Ever. I mean Movie, not lovie.", MovieId = 4 },
                        new { ReviewId = 9, Content = "This sucks. My favorite actor wasn't in it.", MovieId = 5 },
                        new { ReviewId = 10, Content = "Oh boy... please don't watch this one.", MovieId = 5 },
                        new { ReviewId = 11, Content = "Oh boy... please don't watch this one.", MovieId = 6 },
                        new { ReviewId = 12, Content = "Yessssssssssssssssssssssssssss.", MovieId = 6 },
                        new { ReviewId = 13, Content = "Invoked a sense of wonder in regards to space travel and time. Renewed my belief in kind, caring extraterrestrial beings.", MovieId = 7 },
                        new { ReviewId = 14, Content = "Good depiction of rural American family life, and the heartfelt dynamics between grandparents and their offspring.", MovieId = 7 },
                        new { ReviewId = 15, Content = "What Bobby said.", MovieId = 8 },
                        new { ReviewId = 16, Content = "Too weird, I didn't get what was going on. Made me want to visit my local petting zoo.", MovieId = 8 },
                        new { ReviewId = 17, Content = "Inspired me watch Fixer Upper and fix up my own house, to replicate the house's interactive, unique and cozy features.", MovieId = 9 },
                        new { ReviewId = 18, Content = "A must-see.", MovieId = 9 }
                    );
                });

            modelBuilder.Entity("Reviews.Model.Movie", b =>
                {
                    b.HasOne("Reviews.Model.Genre", "Genre")
                        .WithMany("Movies")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Reviews.Model.Review", b =>
                {
                    b.HasOne("Reviews.Model.Movie", "ReviewMovie")
                        .WithMany("Reviews")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
