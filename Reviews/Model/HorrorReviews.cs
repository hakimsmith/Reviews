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

        public int HorrorReviewsId { get; set; }

        public string Content { get; set; }

        public int MovieId { get; set; }

        public Movie ReviewMovie { get; set; }

        public HorrorReviews(int horrorReviewsId, string content)
        {
            HorrorReviewsId = horrorReviewsId;
            Content = content;
        }

        public HorrorReviews()
        {

        }
       
    }

    
}

