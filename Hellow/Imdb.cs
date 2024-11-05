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

        public void PrintMovies()
        {
            Console.WriteLine("Movies:");
            foreach (var movie in listOfAllMovies)
            {
                Console.WriteLine($"- ID: {movie.Id}, Title: {movie.Title}, Length: {movie.LengthOfMovie} min");
            }
            Console.WriteLine();
        }

        public void PrintSeries()
        {
            Console.WriteLine("Series:");
            foreach (var series in listOfAllSeries)
            {
                Console.WriteLine($"- ID: {series.Id}, Title: {series.Title}, Episodes: {series.Episodes.Count}");
            }
            Console.WriteLine();
        }

        public void PrintEpisodes()
        {
            Console.WriteLine("Episodes:");
            foreach (var episode in listOfAllEpisodes)
            {
                Console.WriteLine($"- ID: {episode.Id}, Title: {episode.TitleOfEpisode}, Length: {episode.LengthOfEpisode} min, Season: {episode.Season}, Series ID: {episode.SeriesID}");
            }
            Console.WriteLine();
        }

        public void PrintActors()
        {
            Console.WriteLine("Actors:");
            foreach (var actor in listOfAllActors)
            {
                Console.WriteLine($"- ID: {actor.Id}, Name: {actor.Name}, Age: {actor.Age}");
            }
            Console.WriteLine();
        }

        public void PrintDirectors()
        {
            Console.WriteLine("Directors:");
            foreach (var director in listOfAllDirectors)
            {
                Console.WriteLine($"- ID: {director.Id}, Name: {director.Name}, Age: {director.Age}");
            }
            Console.WriteLine();
        }

        public void PrintUsers()
        {
            Console.WriteLine("Users:");
            foreach (var user in listOfAllUsers)
            {
                Console.WriteLine($"- ID: {user.Id}, Name: {user.Name}, Age: {user.Age}");
            }
            Console.WriteLine();
        }

        public void PrintRatings()
        {
            Console.WriteLine("Ratings:");
            foreach (var rating in listOfAllRatings)
            {
                Console.WriteLine($"- Content: {rating.ContentRated.Title}, Rating: {rating.RatingValue}/10, User Name: {rating.UserRater.Name}");
            }
            Console.WriteLine();
        }

        public void PrintPersonsInContent()
        {
            Console.WriteLine("Actors in content:");
            List<MediaContent> allMedia = new List<MediaContent>();
            allMedia.AddRange(listOfAllMovies);
            allMedia.AddRange(listOfAllSeries);
            foreach (var content in allMedia)
            {
                Console.WriteLine($"- Actors and directors in {content.Title}: ");
                Console.WriteLine("- Actors: ");
                foreach(var actor in content.GetActors())
                {
                    Console.WriteLine($"- {actor.Name}, Oscar wins: {actor.OscarWins}");
                }
                Console.WriteLine("- Directors: ");
                foreach (var director in content.GetDirectors())
                {
                    Console.WriteLine($"- {director.Name}, Oscar wins: {director.OscarWins}");
                }
            }
            Console.WriteLine();
        }

        // Print all lists
        public void PrintAll()
        {
            PrintMovies();
            PrintSeries();
            PrintEpisodes();
            PrintActors();
            PrintDirectors();
            PrintUsers();
            PrintRatings();
            PrintPersonsInContent();
        }



    }

}
