using Microsoft.AspNetCore.Mvc;
using Reviews.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reviews.Controllers 
{
    public class ReviewController
    {
        public SiteContext Db = new SiteContext();

            
        
            public ViewResult GetById(int id)
            {
                return Db.(c => c.HorrorReviewsId == id);
            }
        
    }
}
