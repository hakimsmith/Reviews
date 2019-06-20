using Reviews.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reviews.Repositories
{
    public class MovieRepository : IRepository<Movie>
    {
        public List<Movie> nMovies;
        public MovieRepository()
        {
            //nMovies = new List<Movie>()
            //{
            //    new Movie(111, "Blair Witch Project", "BlairWitch.jpg", "1999 American supernatural horror film written, directed and edited by Daniel Myrick Eduardo Sanchez."),

            //    new Movie(222, "Hereditary", "Hereditary.jpg", "2018 American psychological horror drama film written and directed by  Ari Aster."),

            //    new Movie(333, "Saw", "Saw.jpg", "2004 American psychological horror-thriller filmed and directed by James Wan." ),

            //    new Movie(444, "The Thing", "TheThing.jpg", "1982 science fiction horror film directed by John Carpenter."),

            //    new Movie(555, "War of the Worlds","WarofWorlds.jpg", "War of the Worlds, 2005 American science-fiction action film directed by Steven Spielberg and written by Josh Friedman and David Koepp, loosely based on the 1898 novel of the same title by H. G. Wells"),

            //    new Movie(666, "Event Horizon","EventHorizon.jpg","1997 film. In 2047 a group of astronauts are sent to investigate and salvage the starship ‘Event Horizon’ which disappeared mysteriously 7 years before on its maiden voyage. With its return, the crew of the ‘Lewis and Clark’ discovers the real truth behind the disappearance of the ‘Event Horizon’ – and something even more terrifying."),

            //    new Movie(777, "Texas Chainsaw Massacre", "TexasChainsaw", "1974 film, Five friends visiting their grandfather’s house in the country are hunted and terrorized by a chain-saw wielding killer and his family of grave-robbing cannibals."),

            //    new Movie(888, "Cabin in the Woods", "CabinInWoods.png", "2012 American horror comedy film directed by Drew Goddard in his directorial debut, produced by Joss Whedon, and written by Whedon and Goddard."),

            //    new Movie(999, "Paranormal Activity", "ParanormalActivity", "2007 film. After a young, middle class couple moves into a suburban ‘starter’ tract house, they become increasingly disturbed by a presence that may or may not be somehow demonic but is certainly most active in the middle of the night. Especially when they sleep. Or try to.")
            //};
        }
        public IEnumerable<Movie> GetAll()
                {
                     throw new NotImplementedException();
                }

         public Movie GetById(int id)
                 {
                    throw new NotImplementedException();
                 }
    }
}
