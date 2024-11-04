using Hellow.Content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hellow
{
    internal  class Imdb
    {

        public int Id { get; set; }
        public int numberOfMovies = 0;
        public int numberOfSeries = 0;
        public int numberOfRatings = 0;


        public List<Movie> listOfAllMovies = new List<Movie>();
        public List<Series> listOfAllSeries = new List<Series>();
        public List<Episode> listOfAllEpisodes = new List<Episode>();
        public List<Actor> listOfAllActors = new List<Actor>();
        public List<Director> listOfAllDirectors = new List<Director>();
        public List<User> listOfAllUsers = new List<User>();
        public List<Rating> listOfAllRatings = new List<Rating>();

         



    }

}
