using Reviews.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reviews.Model
{
    public class Movie
    {
        public int MovieId { get; set; }
        public int GenreId { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        

        public Genre Genre { get; set; }

        //public ReviewRepository RevRepo { get; set; }

        public List<Review> Reviews { get; set; }



        public Movie(int movieId, int genreId, string title, string imageUrl, string description)
        {
            MovieId = movieId;
            GenreId = genreId;
            Title = title;
            ImageUrl = imageUrl;
            Description = description;           
        }

        public Movie()
        {

        }
    }
}
