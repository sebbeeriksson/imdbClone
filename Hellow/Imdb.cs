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

        public void InitalzieTestDataToImdb()
        {
            try
            {
                //initalizing movies and series
                foreach (var movie in Data.movies)
                {
                    AddContentToImdb(movie);
                    //Console.WriteLine($"Added Movie: {movie.Title}");
                }

                foreach (var series in Data.seriesList)
                {
                    AddContentToImdb(series);
                    AddEpisodesToSeries(series);
                    //Console.WriteLine($"Added Series: {series.Title}");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }
        public void AddEpisodesToSeries(Series series)
        {
            switch (series.SeriesID) 
            {
                case 1:
                    foreach (var episode in Data.listOfBreakingBadEpisodes)
                    {
                        series.AddEpisodeToShow(episode);
                    }
                    break;

                case 2:
                    foreach (var episode in Data.listOfGameOfThronesEpisodes)
                    {
                        series.AddEpisodeToShow(episode);
                    }
                    break;
                case 3:
                    foreach (var episode in Data.listOfStrangerThingsEpisodes)
                    {
                        series.AddEpisodeToShow(episode);
                    }
                    break;
                case 4:
                    foreach (var episode in Data.listOfTheOfficeEpisodes)
                    {
                        series.AddEpisodeToShow(episode);
                    }
                    break;



            }
        }

    }
    
}
