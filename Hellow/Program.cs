using System;
using System.Threading.Tasks;
using System.Configuration;

namespace Hellow
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Imdb imdb = new Imdb();
            // Define your Azure AD Authentication connection string
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

            // Initialize the DB class with the connection string
            var db = new DataBaseLoader(connectionString, imdb);

            // Test the connection and query the database
            await db.LoadDataFromDBToObjects();






            // Example: Execute an INSERT command
            /*
            string insertQuery = "INSERT INTO Movies (TITLE, LENGTH) VALUES ('New Movie', 120)";
            await db.ExecuteNonQueryAsync(insertQuery);
            */

            foreach(Movie movie in imdb.listOfAllMovies) 
            {
                Console.WriteLine(movie.Title);
            }
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
