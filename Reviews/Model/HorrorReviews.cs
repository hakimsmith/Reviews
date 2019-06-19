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
        public string Content { get; set; }

        public HorrorReviews(int movieId, string content)
        {
            MovieId = movieId;
            Content = content;
        }
       
    }

    
}

