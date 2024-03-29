﻿using Reviews.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reviews.Repositories
{
    public class MovieRepository : IRepository<Movie>
    {
        private SiteContext db;

        public MovieRepository(SiteContext db)
        {
            this.db = db;
        }

        public IEnumerable<Movie> GetAll()
        {
            return db.Movies;
        }

        public Movie GetById(int id)
        {
            return db.Movies.Single(c => c.MovieId == id);

        }


        //unused
        public void Create(Movie obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(Movie obj)
        {
            throw new NotImplementedException();
        }

        public void Edit(Movie obj)
        {
            throw new NotImplementedException();
        }
    }
}
