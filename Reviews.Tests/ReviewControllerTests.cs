using Microsoft.AspNetCore.Mvc;
using System;
using Xunit;
using NSubstitute;
using Reviews.Repositories;
using Reviews.Model;
using System.Collections.Generic;
using Reviews.Controllers;

namespace Reviews.Tests
{
    
        public class MovieControllerTests
        {
            MovieController underTest;
            IRepository<Movie> revRepo;
            
            public MovieControllerTests()
        {
            revRepo = Substitute.For<IRepository<Movie>>();
            underTest = new MovieController(revRepo);
        }

        [Fact]
        public void AllMovies_Returns_A_View()
        {
            var result = underTest.AllMovies();

            Assert.IsType<ViewResult>(result);
        }

        }
    
}
