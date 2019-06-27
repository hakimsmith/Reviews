using Microsoft.AspNetCore.Mvc;
using Reviews.Model;
using Reviews.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reviews.Controllers
{
    public class MovieController : Controller
    {
        IRepository<Movie> movierepos;
        public MovieController(IRepository<Movie> movierepos) 
        {
            this.movierepos = movierepos;           
        }

        //Takes user to the AllMovies view which displays every movie. 
        public ViewResult AllMovies()
        {
            var model = movierepos.GetAll();
            return View(model);
        }

        //Takes user to the SingleMovie view which displays info about the movie they selected.
        public ActionResult SingleMovie(int id)
        {
            var model = movierepos.GetById(id);
            return View(model);
        }

    }
}
