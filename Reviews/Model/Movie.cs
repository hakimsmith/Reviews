﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reviews.Model
{
    public class Movie
    {
        public int MovieId { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }

        public Category Category { get; set; }


        public List<HorrorReviews> Reviews { get; set; }



        public Movie(int movieId, string title, string imageUrl, string description)
        {
            MovieId = MovieId;
            Title = title;
            ImageUrl = imageUrl;
            Description = description;           
        }

        public Movie()
        {

        }
    }
}
