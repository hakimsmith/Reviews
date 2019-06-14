using Microsoft.AspNetCore.Mvc;
using Reviews.Controllers;
using System;
using Xunit;

namespace Reviews.Tests
{
    public class UnitTest1
    {
        public class HomeControllerTests
        {
            [Fact]
            public void Index_Returns_View()
            {
                var underTest = new HomeController();

                var result = underTest.Index();

                Assert.IsType<ViewResult>(result);
            }
        }
    }
}
