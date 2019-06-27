using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using NSubstitute;
using Reviews.Repositories;
using Reviews.Model;
using Reviews.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace Reviews.Tests
{
    public class ReviewControllerTests
    {
        ReviewController underTest;
        IRepository<Review> revRepo;
        SiteContext db;

        public ReviewControllerTests()
        {
            revRepo = Substitute.For<IRepository<Review>>();
            underTest = new ReviewController(revRepo);
            db = new SiteContext();
         }

        [Fact]

        public void Review_Is_Created_By_Create_Action()
        {

            Review review = new Review();

            //ReviewController underTest = new ReviewController ();

            underTest.CreateReview(2);
            var result = db.Reviews;
            Assert.Equals(1);
            
        }
    }
}
