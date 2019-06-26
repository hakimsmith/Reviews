using Reviews.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reviews.Repositories
{
    public class ReviewRepository : IRepository<Review>
    {

        private SiteContext db;
        public ReviewRepository(SiteContext db)
        {
            this.db = db;
        }
        public IEnumerable<Review> GetAll()
        {
            return db.Reviews;
        }

        public Review GetById(int id)
        {
            return db.Reviews.Single(c => c.ReviewId == id);
        }

        public void Create(Review review)
        {

            db.Reviews.Add(review);
            db.SaveChanges();
        }

        public void Delete(Review review)
        {
            db.Reviews.Remove(review);
            db.SaveChanges();
        }

        public void Edit(Review review)
        {
            using (var db = new SiteContext())
            {
                var result = db.Reviews.SingleOrDefault( r => r.ReviewId == review.ReviewId);
                if (result != null)
                {
                    result.Content = review.Content;
                    db.SaveChanges();
                }
            }
        }
    }
}
