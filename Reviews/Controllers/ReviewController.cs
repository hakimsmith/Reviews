﻿using Microsoft.AspNetCore.Mvc;
using Reviews.Model;
using Reviews.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reviews.Controllers 
{
    public class ReviewController : Controller
    {
        IRepository<Review> revrepos;
        public ReviewController(IRepository<Review> revrepos)
        {
            this.revrepos = revrepos;
        }

        public ViewResult Index()
        {
            var model = revrepos.GetAll();
            return View(model);
        }



        public ActionResult SingleReview(int id)
        {
            var model = revrepos.GetById(id);
            return View(model);
        }

        public IActionResult OnGetPartial() =>new PartialViewResult
        {
            ViewName = "SingleMovieReviews",
            ViewData = ViewData,
        };

        [HttpGet]
        public ViewResult CreateReview()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateReview(Review review)
        {
            revrepos.Create(review);
            return RedirectToAction("AllMovies", "Movie");
        }
    }
}
