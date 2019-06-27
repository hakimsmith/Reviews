using Microsoft.AspNetCore.Mvc;
using Reviews.Model;
using Reviews.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reviews.Controllers
{
    public class GenreController : Controller
    {
        IRepository<Genre> genrerepos;

        public GenreController(IRepository<Genre> genrerepos)
        {
            this.genrerepos = genrerepos;
        }

        //Takes user to the main landing page named AllGenres, displays genres.
        public ViewResult AllGenres()
        {
            var model = genrerepos.GetAll();
            return View(model);
        }

        //Takes user to the Single Genre page which displays the movies within the selected genre.
        public ActionResult SingleGenre(int id)
        {
            var model = genrerepos.GetById(id);
            return View(model);
        }

    }
}
