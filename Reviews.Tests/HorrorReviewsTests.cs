using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Microsoft.AspNetCore.Mvc;
using Reviews.Model;

namespace Reviews.Tests
{

    public class HorrorReviewsTests 
    {
        [Fact]
        public void Index_Returns_Image()
        {
            HorrorReviews underTest = new HorrorReviews(111, "BlairWitchProject", "/wwwroot/Images/BlairWitch.jpg/", "1999 American supernatural horror film written, directed and edited by Daniel Myrick Eduardo Sanchez.", "Horror", "This is a great family movie, recommend you bring the kids, especially the young ones! Full of laughs, and life lessons, too. As soon as we got out of the theatre, my six year old wanted to see it again!");

            var result = underTest.ImageUrl;

            Assert.Equal("/wwwroot/Images/BlairWitch.jpg/" , result);
        }
    }
}
