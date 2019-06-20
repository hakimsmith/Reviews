using Microsoft.AspNetCore.Mvc;
using Reviews.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reviews.Controllers
{
    public class MovieController : Controller
    {
        public ViewResult Index()
        {
            ReviewRepository revrepos = new ReviewRepository();
            var model = revrepos.GetAll();
            return View(model);
        }
        public ActionResult Single(int id)
        {
            ReviewRepository revrepos = new ReviewRepository();
            var model = revrepos.GetById(id);
            return View(model);
        }

    }
}
