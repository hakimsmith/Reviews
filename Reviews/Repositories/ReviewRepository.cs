using Reviews.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reviews.Repositories
{
    public class ReviewRepository : IRepository<Review>
    {

        public List<Review> movies;
        public ReviewRepository()
        {
            movies = new List<Review>()
            {
                new Review(111, "This is a great family movie, recommend you bring the kids, especially the young ones! Full of laughs, and life lessons, too. As soon as we got out of the theatre, my six year old wanted to see it again!"),

                new Review(222,  "A movie about the power of motherhood, in my opinion, one of the best examples of this. The strong religious themes with an emphasis on family values really spoke to me in a profound way."),

                new Review(333,  "His inventions that brought people together inspired my creativity, and pushed me to put myself in new, uncomfortable situations. A must-see for all aspiring inventors."),

                new Review(444, "Definitely a movie for animal lovers. Teaches you to trust the people around you, don't be a cynic. Hands down, the greatest horror movie ever made."),

                new Review(555, "This sucks. My favorite actor wasn't in it."),

                new Review(666, "Invoked a sense of wonder in regards to space travel and time. Renewed my belief in kind, caring extraterrestrial beings. "),

                new Review(777, "Good depiction of rural American family life, and the heartfelt dynamics between grandparents and their offspring. "),

                new Review(888, "Too weird, I didn't get what was going on. Made me want to visit my local petting zoo."),

                new Review(999, "Inspired me watch Fixer Upper and fix up my own house, to replicate the house's interactive, unique and cozy features.")

            };
        }

        public IEnumerable<Review> GetAll()
        {
            return movies;
        }

        public Review GetById(int id)
        {
            return movies.Single(c => c.ReviewId == id);
        }

        
        
    }
}
