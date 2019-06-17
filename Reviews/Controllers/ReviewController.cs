using Microsoft.AspNetCore.Mvc;
using Reviews.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reviews.Controllers
{
    public class ReviewController : Controller
    {
        public ViewResult Index()
        {
            ReviewRepository revrepos = new ReviewRepository();
            var model = revrepos.GetAll();
            return View(model);
        }
<<<<<<< HEAD
        public ViewResult Single()
        {
            ReviewRepository revrepos = new ReviewRepository();
            var model = revrepos.GetById(111);
            return View(model);
        }
=======
>>>>>>> html
    }
}
