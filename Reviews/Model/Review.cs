using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Reviews.Model
{
    public class Review
    {
        [Key]
        public int ReviewId { get; set; }
        public string Content { get; set; }
        public int MovieId { get; set; }

        public virtual Movie ReviewMovie { get; set; }

        public Review()
        {
        }

        public Review(int reviewId, string content)
        {
            ReviewId = reviewId;
            Content = content;
        }

        
    }
}

