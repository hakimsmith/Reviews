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
        public DbSet<Review> HorrorReviews { get; set; }
        public DbSet<Genre> Categories { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=SiteDb;Trusted_Connection=True;";

            optionsBuilder.UseSqlServer(connectionString);

            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().HasData(
                new Movie
                {
                    MovieId = 1,
                    Title = "Blair Witch Project",
                    ImageUrl = "BlairWitch.jpg",
                    Description = "1999 American supernatural horror film written, directed and edited by Daniel Myrick Eduardo Sanchez."
                },
                new Movie
                {
                    MovieId = 2,
                    Title = "Hereditary",                   
                    ImageUrl = "Hereditary.jpg",
                    Description = "2018 American psychological horror drama film written and directed by  Ari Aster."
                },
                new Movie
                {
                    MovieId = 3,
                    Title = "Saw",
                    ImageUrl = "Saw.jpg",
                    Description = "2004 American psychological horror-thriller filmed and directed by James Wan."
                },
                new Movie
                {
                    MovieId = 4,
                    Title = "The Thing",
                    ImageUrl = "TheThing.jpg",
                    Description = "1982 science fiction horror film directed by John Carpenter."
                },
                new Movie
                {
                    MovieId = 5,
                    Title = "War of the Worlds",
                    ImageUrl = "WarofWorlds.jpg",
                    Description = "War of the Worlds, 2005 American science-fiction action film directed by Steven Spielberg and written by Josh Friedman and David Koepp, loosely based on the 1898 novel of the same title by H. G. Wells"
                },
                new Movie
                {
                    MovieId =6 ,
                    Title = "Event Horizon" ,
                    ImageUrl = "EventHorizon.jpg",
                    Description = "1997 film. In 2047 a group of astronauts are sent to investigate and salvage the starship ‘Event Horizon’ which disappeared mysteriously 7 years before on its maiden voyage. With its return, the crew of the ‘Lewis and Clark’ discovers the real truth behind the disappearance of the ‘Event Horizon’ – and something even more terrifying."
                },
                new Movie
                {
                    MovieId =7,
                    Title = "Texas Chainsaw Massacre",
                    ImageUrl = "TexasChainsaw.jpg",
                    Description = "1974 film, Five friends visiting their grandfather’s house in the country are hunted and terrorized by a chain-saw wielding killer and his family of grave-robbing cannibals."
                },
                new Movie
                {
                    MovieId =8,
                    Title = "Cabin in the Woods",
                    ImageUrl = "CabinInWoods.png",
                    Description = "2012 American horror comedy film directed by Drew Goddard in his directorial debut, produced by Joss Whedon, and written by Whedon and Goddard."
                },
                new Movie
                {
                    MovieId = 9,
                    Title = "Paranormal Activity" ,
                    ImageUrl = "ParanormalActivity.jpg",
                    Description = "2007 film. After a young, middle class couple moves into a suburban ‘starter’ tract house, they become increasingly disturbed by a presence that may or may not be somehow demonic but is certainly most active in the middle of the night. Especially when they sleep. Or try to."
                }
            );

            modelBuilder.Entity<Review>().HasData(

        new Review { ReviewId = 1,  MovieId = 1 , Content= "This is a great family movie, recommend you bring the kids, especially the young ones!Full of laughs, and life lessons too. As soon as we got out of the theatre, my six year old wanted to see it again!" },

        new Review { ReviewId = 2, MovieId = 1, Content = "King Lear" }

        // new HorrorReviews { HorrorReviewsId = 2, MovieId = 2, Content = "Othello" }


        //new HorrorReviews { HorrorReviewsId = 3, MovieId = 3, Content = "Othello" },

        //new HorrorReviews { HorrorReviewsId = 4, MovieId = 4, Content = "Othello" },

        //new HorrorReviews { HorrorReviewsId = 5, MovieId = 5, Content = "Othello" },

        //new HorrorReviews { HorrorReviewsId = 6, MovieId = 6, Content = "Othello" },

        //new HorrorReviews { HorrorReviewsId = 3, MovieId = 7, Content = "Othello" },

        //new HorrorReviews { HorrorReviewsId = 3, MovieId = 8, Content = "Othello" },

        //new HorrorReviews { HorrorReviewsId = 3, MovieId = 9, Content = "Othello" }

    );
        }
    }
}
