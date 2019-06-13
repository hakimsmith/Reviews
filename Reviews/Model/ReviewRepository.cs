using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reviews.Model
{
    public class ReviewRepository
    {
        HorrorReviews horrorReview1 = new HorrorReviews(111, "BlairWitchProject", "/wwwroot/Images/BlairWitch.jpg/", "1999 American supernatural horror film written, directed and edited by Daniel Myrick Eduardo Sanchez.", "Horror", "This is a great family movie, recommend you bring the kids, especially the young ones! Full of laughs, and life lessons, too. As soon as we got out of the theatre, my six year old wanted to see it again!");

        HorrorReviews horrorReview2 = new HorrorReviews(222, "Hereditary", "/Images/Hereditary.jpg/", "2018 American psychological horror drama film written and directed by  Ari Aster.", "Horror", "A movie about the power of motherhood, in my opinion, one of the best examples of this. The strong religious themes with an emphasis on family values really spoke to me in a profound way.");

        HorrorReviews horrorReview3 = new HorrorReviews(333, "Saw", "/Images/Saw.jpg/", "2004 American psychological horror-thriller filmed and directed by James Wan.", "Horror", "His inventions that brought people together inspired my creativity, and pushed me to put myself in new, uncomfortable situations. A must-see for all aspiring inventors.");

        HorrorReviews horrorReview4 = new HorrorReviews(444, "The Thing", "/Images/TheThing.jpg/", "1982 science fiction horror film directed by John Carpenter.", "Horror", "Definitely a movie for animal lovers. Teaches you to trust the people around you, don't be a cynic. Hands down, the greatest horror movie ever made.");

    }
}
