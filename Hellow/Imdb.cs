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

        public List<Movie> listOfAllMovies = new List<Movie>();
        public List<Series> listOfAllSeries = new List<Series>();

        public void AddContentToImdb(MediaContent content)
        {
            
            if (content is Movie movie)
            {
                listOfAllMovies.Add(movie);
            }
            else if (content is Series series) 
            {
                listOfAllSeries.Add(series);
            }
            else { Console.WriteLine("Content", content, "can't be added"); }
        }

    }
    
}
