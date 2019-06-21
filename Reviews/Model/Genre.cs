using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reviews.Model
{
    public class Genre
    {
        public int GenreId { get; set; }

        public string GenreName { get; set; }

        public List<Movie> Movies { get; set; }
    }

    
}
