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

        public ActionResult SingleReview(int id)
        {
            var model = revrepos.GetById(id);
            return View(model);
        }

        //Create Review
        [HttpGet]
        public ViewResult CreateReview(int id)
        {
            ViewBag.MovieId = id;
            return View();
        }

        [HttpPost]
        public ActionResult CreateReview(Review review)
        {
            revrepos.Create(review);
            return RedirectToAction("AllMovies", "Movie");
        }

        //Delete Review
        [HttpGet]
        public ViewResult DeleteReview(int id)
        {
            ViewBag.ReviewId= id;
            return View();
        }

        [HttpPost]
        public ActionResult DeleteReview(Review review)
        {
            revrepos.Delete(review);
            return RedirectToAction("AllMovies", "Movie");
        }
        [HttpGet]
        public ActionResult EditReview(int id)
        {
          
            ViewBag.ReviewId = id;
            return View();
        }

        [HttpPost]
        public ActionResult EditReview(Review review)
        {
            revrepos.Edit(review);
               
            return RedirectToAction("AllMovies", "Movie");
        }
    }
}
