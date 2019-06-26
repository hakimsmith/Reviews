using Reviews.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reviews.Repositories
{
    public class GenreRepository : IRepository<Genre>
    {
        private SiteContext db;

        public GenreRepository(SiteContext db)
        {
            this.db = db;
        }

        public void Create(Genre obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(Genre obj)
        {
            throw new NotImplementedException();
        }

        public void Edit(Genre obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Genre> GetAll()
        {
            return db.Genres;
        }

        public Genre GetById(int id)
        {
            return db.Genres.Single(c => c.GenreId == id);
        }

        
    }
}
