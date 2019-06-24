using Microsoft.EntityFrameworkCore;
using Reviews.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reviews
{
    public class SiteContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Genre> Genres { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=SiteDb;Trusted_Connection=True;";

            optionsBuilder.UseSqlServer(connectionString)
                   .UseLazyLoadingProxies();

            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().HasData(
                new Movie
                {
                    MovieId = 1,
                    GenreId = 3,
                    Title = "Blair Witch Project",
                    ImageUrl = "BlairWitch.jpg",
                    Description = "1999 American supernatural horror film written, directed and edited by Daniel Myrick Eduardo Sanchez."
                },
                new Movie
                {
                    MovieId = 2,
                    GenreId = 3,
                    Title = "Hereditary",
                    ImageUrl = "Hereditary.jpg",
                    Description = "2018 American psychological horror drama film written and directed by  Ari Aster."
                },
                new Movie
                {
                    MovieId = 3,
                    GenreId = 2,
                    Title = "Saw",
                    ImageUrl = "Saw.jpg",
                    Description = "2004 American psychological horror-thriller filmed and directed by James Wan."
                },
                new Movie
                {
                    MovieId = 4,
                    GenreId = 1,
                    Title = "The Thing",
                    ImageUrl = "TheThing.jpg",
                    Description = "1982 science fiction horror film directed by John Carpenter."
                },
                new Movie
                {
                    MovieId = 5,
                    GenreId = 1,
                    Title = "War of the Worlds",
                    ImageUrl = "WarofWorlds.jpg",
                    Description = "War of the Worlds, 2005 American science-fiction action film directed by Steven Spielberg and written by Josh Friedman and David Koepp, loosely based on the 1898 novel of the same title by H. G. Wells"
                },
                new Movie
                {
                    MovieId = 6,
                    GenreId = 1,
                    Title = "Event Horizon",
                    ImageUrl = "EventHorizon.jpg",
                    Description = "1997 film. In 2047 a group of astronauts are sent to investigate and salvage the starship ‘Event Horizon’ which disappeared mysteriously 7 years before on its maiden voyage. With its return, the crew of the ‘Lewis and Clark’ discovers the real truth behind the disappearance of the ‘Event Horizon’ – and something even more terrifying."
                },
                new Movie
                {
                    MovieId = 7,
                    GenreId = 2,
                    Title = "Texas Chainsaw Massacre",
                    ImageUrl = "TexasChainsaw.jpg",
                    Description = "1974 film, Five friends visiting their grandfather’s house in the country are hunted and terrorized by a chain-saw wielding killer and his family of grave-robbing cannibals."
                },
                new Movie
                {
                    MovieId = 8,
                    GenreId = 2,
                    Title = "Cabin in the Woods",
                    ImageUrl = "CabinInWoods.png",
                    Description = "2012 American horror comedy film directed by Drew Goddard in his directorial debut, produced by Joss Whedon, and written by Whedon and Goddard."
                },
                new Movie
                {
                    MovieId = 9,
                    GenreId = 3,
                    Title = "Paranormal Activity",
                    ImageUrl = "ParanormalActivity.jpg",
                    Description = "2007 film. After a young, middle class couple moves into a suburban ‘starter’ tract house, they become increasingly disturbed by a presence that may or may not be somehow demonic but is certainly most active in the middle of the night. Especially when they sleep. Or try to."
                }
            );

            modelBuilder.Entity<Review>().HasData(

        new Review { ReviewId = 1, MovieId = 1, Content = "This is a great family movie, recommend you bring the kids, especially the young ones!Full of laughs, and life lessons too. As soon as we got out of the theatre, my six year old wanted to see it again!" },

        new Review { ReviewId = 2, MovieId = 1, Content = "Great Movie.!!" },

        new Review { ReviewId = 3, MovieId = 2, Content = "A movie about the power of motherhood, in my opinion, one of the best examples of this.The strong religious themes with an emphasis on family values really spoke to me in a profound way."},

        new Review { ReviewId = 4, MovieId = 2, Content = "Blech. I hated it." },

        new Review { ReviewId = 5, MovieId = 3, Content = "His inventions that brought people together inspired my creativity, and pushed me to put myself in new, uncomfortable situations. A must-see for all aspiring inventors." },

        new Review { ReviewId = 6, MovieId = 3, Content = "It was ok..." },

        new Review { ReviewId = 7, MovieId = 4, Content = "Definitely a movie for animal lovers. Teaches you to trust the people around you, don't be a cynic. Hands down, the greatest horror movie ever made." },

        new Review { ReviewId = 8, MovieId = 4, Content = "Greeatest. Lovie. Ever. I mean Movie, not lovie." },

        new Review { ReviewId = 9, MovieId = 5, Content = "This sucks. My favorite actor wasn't in it." },

        new Review { ReviewId = 10, MovieId = 5, Content = "Oh boy... please don't watch this one." },

        new Review { ReviewId = 11, MovieId = 6, Content = "Oh boy... please don't watch this one." },

        new Review { ReviewId = 12, MovieId = 6, Content = "Yessssssssssssssssssssssssssss." },

        new Review { ReviewId = 13, MovieId = 7, Content = "Invoked a sense of wonder in regards to space travel and time. Renewed my belief in kind, caring extraterrestrial beings." },

        new Review { ReviewId = 14, MovieId = 7, Content = "Good depiction of rural American family life, and the heartfelt dynamics between grandparents and their offspring." },

        new Review { ReviewId = 15, MovieId = 8, Content = "What Bobby said." },

        new Review { ReviewId = 16, MovieId = 8, Content = "Too weird, I didn't get what was going on. Made me want to visit my local petting zoo." },

        new Review { ReviewId = 17, MovieId = 9, Content = "Inspired me watch Fixer Upper and fix up my own house, to replicate the house's interactive, unique and cozy features." },

        new Review { ReviewId = 18, MovieId = 9, Content = "A must-see." }


    );
            modelBuilder.Entity<Genre>().HasData(
               new Genre
               {
                   GenreId = 1,
                   GenreName = "Sci Fi"

               },
               new Genre
               {
                   GenreId = 2,
                   GenreName = "Slasher"
               },
               new Genre
               {
                   GenreId = 3,
                   GenreName = "Supernatural"
               }
               
              );
              
        }
    }
}
