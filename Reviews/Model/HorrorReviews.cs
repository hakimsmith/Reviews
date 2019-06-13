using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Reviews.Model
{
    public class HorrorReviews
    {
         
        [Key]

        public int MovieId { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string Content { get; set; }

        public HorrorReviews(int movieId, string title, string imageUrl, string description, string category, string content)
        {
            MovieId = movieId;
            Title = title;
            ImageUrl = imageUrl;
            Description = description;
            Category = category;
            Content = content;
        }
       
    }

    
}

