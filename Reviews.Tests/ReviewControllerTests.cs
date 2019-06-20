using Microsoft.AspNetCore.Mvc;
using Reviews.Controllers;
using System;
using Xunit;

namespace Reviews.Tests
{
    
        public class ReviewControllerTests
        {
            [Fact]
            public void Index_Returns_View()
            {
                    var underTest = new MovieController();

                    var result = underTest.Index();

                    Assert.IsType<ViewResult>(result);
            }

            //[Fact]
            //public void Single_Returns_A_View()
            //{
            //        var underTest = new ReviewController();

            //        var result = underTest.Single();

            //        Assert.IsType<ViewResult>(result);
            // }
        }
    
}
