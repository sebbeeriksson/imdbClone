using System;

namespace Hellow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Imdb imdb = new Imdb();

            try
            {
                //initalizing movies and series
                foreach (var movie in Data.movies)
                {
                    imdb.AddContentToImdb(movie);
                    Console.WriteLine($"Added Movie: {movie.Title}");
                }

                foreach (var series in Data.seriesList)
                {
                    imdb.AddContentToImdb(series);
                    Console.WriteLine($"Added Series: {series.Title}");
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
    }
}
